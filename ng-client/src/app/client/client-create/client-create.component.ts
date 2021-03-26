import { Component, OnInit } from '@angular/core';
import { NgForm, FormGroup, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ClientModel } from 'src/app/Models/ClientModel';
import { ClientService } from 'src/app/services/client.service';

@Component({
  selector: 'app-client-create',
  templateUrl: './client-create.component.html',
  styles: [
  ]
})
export class ClientCreateComponent implements OnInit {

  forma: FormGroup = new FormGroup({})
  client: ClientModel
  clientId: number = 0


  constructor(private _clientService: ClientService, private _router: Router, public _activateRouter: ActivatedRoute,) {
    this.client = new ClientModel(0, '', '', '', '', '', '', '', '')
    this.initForma();
    _activateRouter.params.subscribe(params => {
      debugger
      this.clientId = parseInt(params['id']);
      if (this.clientId > 0) {
        this.getClientById()
      }
    })
  }

  ngOnInit(): void {
    this.initForma();
  }

  initForma() {
    this.forma = new FormGroup({
      'id': new FormControl(this.client.id),
      'primer_nombre': new FormControl(this.client.primer_nombre, Validators.required),
      'segundo_nombre': new FormControl(this.client.segundo_nombre),
      'primer_apellido': new FormControl(this.client.primer_apellido, Validators.required),
      'segundo_apellido': new FormControl(this.client.segundo_apellido),
      'tipo_doc': new FormControl(this.client.tipo_doc, Validators.required),
      'celular': new FormControl(this.client.celular, Validators.required),
      'direccion': new FormControl(this.client.direccion, Validators.required),
      'correo': new FormControl(this.client.correo, Validators.required)
    })
  }

  createClient() {
    
    if (this.forma.invalid) {
      return;
    }

    this._clientService.createClient(this.forma.value)
      .subscribe(client => {
        console.log(client)
        this._router.navigate(['/client'])
      })
  }

  getClientById() {
    this._clientService.getClientById(this.clientId)
      .subscribe(client => {
        console.log(client)
        this.client = client
      })
  }

}
