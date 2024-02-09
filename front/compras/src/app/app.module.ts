import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GuardarCompradorComponent } from './components/comprador/guardar-comprador/guardar-comprador.component';
import { LoginCompradorComponent } from './components/comprador/login-comprador/login-comprador.component';
import { MenuComponent } from './components/menu/menu.component';
import { AuthInterceptor } from './data/authInterceptor';

@NgModule({
  declarations: [
    AppComponent,
    GuardarCompradorComponent,
    LoginCompradorComponent,
    MenuComponent
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
