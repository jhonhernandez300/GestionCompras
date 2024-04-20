import { CanActivateChildFn, CanActivateFn } from '@angular/router';
import { Injectable, inject } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { UsuarioService } from '../data/usuario.service';
import { CanActivateChild, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';


  export const canActivateGuard: CanActivateFn = (  
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ) => {   
    if(inject(UsuarioService).EstaAutenticado()){
      return true;
    }else {
      inject(Router).navigate(['/login-usuario']);
      return false;
    }
  }; 
  
  