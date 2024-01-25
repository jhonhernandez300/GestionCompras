import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GuardarCompradorComponent } from '../app/components/comprador/guardar-comprador/guardar-comprador.component';

const routes: Routes = [
  { path: 'guardar-comprador', component: GuardarCompradorComponent },
  { path: '', component: GuardarCompradorComponent }, 
  { path: '**', component: GuardarCompradorComponent } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
