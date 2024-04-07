import { CanActivateChildFn, CanActivateFn } from '@angular/router';
import { Injectable, inject } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { UsuarioService } from '../data/usuario.service';
import { CanActivateChild, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';


// export const authGuard: CanActivateFn = (route, state) => {
//   return true;
// };
@Injectable({
  providedIn: 'root'
})
export class PermissionsService {
  constructor(private usuarioService: UsuarioService) {}

  canActivate: CanActivateFn = (
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ) => {
    const usuarioService = inject(UsuarioService);
    const router = inject(Router);
  
    return usuarioService.EstaAutenticado()
  };
  
  canActivateChild: CanActivateChildFn = (route: ActivatedRouteSnapshot, state: RouterStateSnapshot) => this.canActivate(route, state);
}

  