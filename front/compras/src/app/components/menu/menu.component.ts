import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent {
  textoDeInput = '';

  constructor(private router: Router) {}

  redirectToProduct() {
    console.log('textoDeInput ', this.textoDeInput);
    this.router.navigate(['/producto-obtener', this.textoDeInput]);
  }
}
