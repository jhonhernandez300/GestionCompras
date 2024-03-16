import { Component, OnInit } from '@angular/core';
import { IProducto } from '../../../data/IProducto';
import { ProductoService } from '../../../data/producto.service';
import { ActivatedRoute, Router } from '@angular/router';


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
  parametroDeBusqueda = 'Masculino';

  constructor(
    private productoService: ProductoService,
    private route: ActivatedRoute, 
    private router: Router
  ) { }

  ngOnInit(): void {
    this.parametroDeBusqueda = this.route.snapshot.params['parametroDeBusqueda'];
    console.log('parametroDeBusqueda' + this.parametroDeBusqueda);

    if (this.parametroDeBusqueda === 'Masculino' || this.parametroDeBusqueda === 'Femenino') {
      this.ConsultarMasBuscados(this.parametroDeBusqueda);
    }else{
      this.ConsultarNombreProducto(this.parametroDeBusqueda);
    }
    
  }

  ConsultarMasBuscados(sexo: string){
    this.productoService.GetMasBuscados(sexo)
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

  ConsultarNombreProducto(nombreProducto: string){
    this.productoService.GetByName(nombreProducto)
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
