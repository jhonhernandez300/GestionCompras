import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GuardarUsuarioComponent } from './components/usuario/guardar-usuario/guardar-usuario.component';
import { LoginUsuarioComponent } from './components/usuario/login-usuario/login-usuario.component';
import { MenuComponent } from './components/menu/menu.component';
import { AuthInterceptor } from './data/authInterceptor';
import { ObtenerComponent } from './components/producto/obtener/obtener.component';
import { ErrorDialogComponent } from './components/utils/error-dialog/error-dialog.component';

@NgModule({
  declarations: [
    AppComponent,
    GuardarUsuarioComponent,
    LoginUsuarioComponent,
    MenuComponent,
    ObtenerComponent,
    ErrorDialogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,    
    FormsModule,    
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
