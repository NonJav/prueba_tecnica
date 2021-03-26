import { Component, OnInit } from '@angular/core';
import { ClientModel } from 'src/app/Models/ClientModel';
import { ClientService } from 'src/app/services/client.service';

@Component({
  selector: 'app-client-list',
  templateUrl: './client-list.component.html',
  styles: [
  ]
})
export class ClientListComponent implements OnInit {

  clients: ClientModel[] = []

  constructor(private _clientService: ClientService) { }

  ngOnInit(): void {
    this.getClients()
  }

  getClients() {
    this._clientService.getClients()
      .subscribe(data => {
        this.clients = data;
      })
  }

  

}
