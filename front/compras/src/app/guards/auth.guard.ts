import { CanActivateFn } from '@angular/router';
import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { UsuarioService } from '../data/usuario.service';


// export const authGuard: CanActivateFn = (route, state) => {
//   return true;
// };
@Injectable()
export class AuthGuard implements CanActivate  {
  constructor(
    private usuarioService: UsuarioService, 
    private router: Router
  ) {}

  canActivate(): boolean {
    return this.checkAuth();
  }

  private checkAuth(): boolean {
    if (this.usuarioService.EstaAutenticado()) {
      return true;
    } else {      
      this.router.navigate(['/login-usuario']);
      return false;
    }
  }
}