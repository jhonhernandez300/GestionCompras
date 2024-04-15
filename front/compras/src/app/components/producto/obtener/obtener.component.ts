import { Component, OnInit, OnChanges } from '@angular/core';
import { IProducto } from '../../../data/IProducto';
import { ProductoService } from '../../../data/producto.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-obtener',
  templateUrl: './obtener.component.html',
  styleUrls: ['./obtener.component.css']
})
export class ObtenerComponent implements OnInit, OnChanges {
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
  idProducto: string = '';

  constructor(
    private productoService: ProductoService,
    private route: ActivatedRoute, 
    private router: Router
  ) { }

  ngOnInit(): void {
    this.parametroDeBusqueda = this.route.snapshot.params['parametroDeBusqueda'];
    this.consultarProductos();
  }

  ngOnChanges() {
    this.consultarProductos();
  }

  consultarProductos() {
    if (this.parametroDeBusqueda === 'Masculino' || this.parametroDeBusqueda === 'Femenino') {
      this.consultarMasBuscados(this.parametroDeBusqueda);
    } else {
      this.consultarNombreProducto(this.parametroDeBusqueda);
    }
  }

  consultarMasBuscados(sexo: string){
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

  consultarNombreProducto(nombreProducto: string){
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

  navigateToDetail(id: string) {
    console.log("De la tabla de producto ", id);
    this.router.navigate(['/producto-detalle', id]); 
  }
}
