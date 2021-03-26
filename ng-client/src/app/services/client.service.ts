import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { ClientModel } from '../Models/ClientModel';
import { URL_BACKEND } from '../app.config'

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private _http: HttpClient) { }

  // ===========================================================================================
  // Consulta todos los clientes del sistema
  // ===========================================================================================
  getClients(): Observable<any> {
    return this._http.get(`${URL_BACKEND}/client`)
      .pipe(
        map((data: any) => {
          return data
        })
      )
  }

  // ===========================================================================================
  // Consulta un cliente por id
  // ===========================================================================================
  getClientById(id:number): Observable<any> {
    return this._http.get(`${URL_BACKEND}/client/getClient/${id}`)
      .pipe(
        map((data: any) => {
          return data
        })
      )
  }

  // ===========================================================================================
  // Registra un nuevo cliente en la base de datos
  // ===========================================================================================
  createClient(client: ClientModel):Observable<ClientModel> {
    return this._http.post(`${URL_BACKEND}/client/add`, client)
      .pipe(
        map((data: any) => {
          return data;
        }),
        catchError(err => {
          return throwError(err)
        })
      )
  }


  // ===========================================================================================
  // Actualiza un cliente en la base de datos
  // ===========================================================================================
  updateClient(client: ClientModel):Observable<ClientModel> {
    return this._http.put(`${URL_BACKEND}/client`, client)
      .pipe(
        map((data: any) => {
          return data;
        }),
        catchError(err => {
          return throwError(err)
        })
      )
  }
}
