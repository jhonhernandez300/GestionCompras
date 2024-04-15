import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { IProducto } from '../../../data/IProducto';
import { ProductoService } from '../../../data/producto.service';

@Component({
  selector: 'app-detalles',
  templateUrl: './detalles.component.html',
  styleUrls: ['./detalles.component.css']  // Corregido "styleUrl" a "styleUrls"
})
export class DetallesComponent implements OnInit {
  id: string = '';
  //item: IProducto[] = [];
  item!: IProducto;

  constructor(
    private route: ActivatedRoute, 
    private router: Router,
    private productoService: ProductoService
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];   
    this.consultarProducto(this.id);
  }

  consultarProducto(id: string){
    this.productoService.GetById(id)
      .subscribe({
        next: (response) => {
          console.log('response', response);
          //this.item = [response];  
          this.item = response;
        },
        error: (error) => {
          console.error(': ', error);
        }
      });
  }
}
