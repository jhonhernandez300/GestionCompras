import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IComprador } from '../data/IComprador';

@Injectable({
  providedIn: 'root'
})
export class CompradorService {

  constructor(private http: HttpClient) { }

  GuardarComprador(Comprador: IComprador): Observable<any> {
    return this.http.post('https://localhost:7127/Comprador/SaveComprador', Comprador);
  }

  UpdateComprador(Comprador: IComprador): Observable<any> {    
    return this.http.put('https://localhost:7127/Comprador/UpdateComprador', Comprador);
  }

  DeleteComprador(CompradorId: Number): Observable<any> {    
    return this.http.delete('https://localhost:7127/Comprador/DeleteComprador'+  "/" + CompradorId);
  }

  GetAllCompradors(): Promise<any> {
    return this.http.get<any>('https://localhost:7127/Comprador/GetAllCompradors').toPromise();    
  } 

  GetCompradorByLastNames(lastNames: string): Observable<any> {    
    return this.http.get('https://localhost:7127/Comprador/GetCompradorByLastNames'+  "/" + lastNames);
  }

  GetCompradorById(idComprador: number): Observable<any> { 
    console.log("Capa services / GetCompradorById con el id " + idComprador);   
    return this.http.get('https://localhost:7127/Comprador/GetCompradorById'+  "/" + idComprador);
  }
}
