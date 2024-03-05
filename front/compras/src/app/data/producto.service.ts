import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IProducto } from './IProducto';

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  constructor(private http: HttpClient) { }

  GetByName(nombre: string): Observable<any> {  
    console.log("Antes de consultar Producto GetByName, el nombre del producto es " + nombre);   
    return this.http.get('https://localhost:7145/Producto/GetByName'+  "/" + nombre);
  }
  
  GetMasBuscados(paraSexo: string): Observable<any> {
    console.log("Antes de consultar Producto GetByName, el nombre del producto es " + paraSexo);
    return this.http.get('https://localhost:7145/Producto/GetMasBuscados' + "/" + paraSexo);
  }
}
