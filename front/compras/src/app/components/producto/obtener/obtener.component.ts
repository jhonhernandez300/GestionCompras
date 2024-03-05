import { Component, OnInit } from '@angular/core';
import { IProducto } from '../../../data/IProducto';
import { ProductoService } from '../../../data/producto.service';

@Component({
  selector: 'app-obtener',
  templateUrl: './obtener.component.html',
  styleUrl: './obtener.component.css'
})
export class ObtenerComponent  implements OnInit {
  producto: IProducto = {
    IdProducto: '58650f7d-2495-4a2c-9092-493dc2ecda63',
    Nombre: '',
    Referencia: '',
    UrlImagen: '', 
    Descripcion: '',
    Color: '',
    Cantidad: 0,
    Talla: '',
    Valor: 0,
    EsDeLosMasBuscados: true,
    ParaSexo: ''
  };

  items!: any[];
  paraSexo = 'Masculino';

  constructor(private productoService: ProductoService) { }

  ngOnInit(): void {
    this.productoService.GetMasBuscados(this.paraSexo)
      .subscribe({
        next: (response) => {
          console.log('response', response);
          this.items = response;
        },
        error: (error) => {
          console.error(': ', error);
        }
      });
  }
}
