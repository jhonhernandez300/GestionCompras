import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GuardarUsuarioComponent } from '../app/components/usuario/guardar-usuario/guardar-usuario.component';
import { LoginUsuarioComponent } from '../app/components/usuario/login-usuario/login-usuario.component';

const routes: Routes = [
  { path: 'guardar-usuario', component: GuardarUsuarioComponent },
  { path: 'login-usuario', component: LoginUsuarioComponent },
  { path: '', component: LoginUsuarioComponent }, 
  { path: '**', component: LoginUsuarioComponent } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
