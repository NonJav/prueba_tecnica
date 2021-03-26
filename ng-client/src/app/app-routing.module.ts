import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientCreateComponent } from './client/client-create/client-create.component';
import { ClientListComponent } from './client/client-list/client-list.component';

const routes: Routes = [
  { path: 'client', component: ClientListComponent },
  { path: 'client/add', component: ClientCreateComponent },
  { path: 'client/:id', component: ClientCreateComponent },

  { path: '**', redirectTo: 'client'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
