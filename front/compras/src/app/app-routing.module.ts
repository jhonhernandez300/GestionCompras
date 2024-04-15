import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GuardarUsuarioComponent } from '../app/components/usuario/guardar-usuario/guardar-usuario.component';
import { LoginUsuarioComponent } from '../app/components/usuario/login-usuario/login-usuario.component';
import { ObtenerComponent } from '../app/components/producto/obtener/obtener.component';
import { DetallesComponent } from './components/producto/detalles/detalles.component';
import { canActivateGuard } from './guards/auth.guard';

const routes: Routes = [
  { path: 'producto-obtener/:parametroDeBusqueda', 
    component: ObtenerComponent, 
    canActivate: [canActivateGuard]},
  //{ path: 'producto-obtener/:parametroDeBusqueda', component: ObtenerComponent},
  { path: 'producto-detalle', component: DetallesComponent},
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
