import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GuardarCompradorComponent } from '../app/components/comprador/guardar-comprador/guardar-comprador.component';
import { LoginCompradorComponent } from '../app/components/comprador/login-comprador/login-comprador.component';

const routes: Routes = [
  { path: 'guardar-comprador', component: GuardarCompradorComponent },
  { path: 'login-comprador', component: LoginCompradorComponent },
  { path: '', component: LoginCompradorComponent }, 
  { path: '**', component: LoginCompradorComponent } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
