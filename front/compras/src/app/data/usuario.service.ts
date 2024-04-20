import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IUsuario } from './IUsuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  lastDate: any;  
  fechaHoraActual: Date = new Date();  

  constructor(private http: HttpClient) { }

//   const headers = new HttpHeaders({
//     'Content-Type': 'application/json'  
// });

EstaAutenticado(): boolean{  
  const lastDate = localStorage.getItem('last date');      
  console.log("lastDate ", lastDate);
  if (lastDate === null) {   
    this.lastDate = new Date(1900, 0, 1, 0, 0, 0); 
  }else {
    this.lastDate = new Date(lastDate);
  }  

  const fechaHoraActual = new Date();
  const diferenciaMs = this.lastDate.getTime() - this.fechaHoraActual.getTime(); 
     
    // Convertir la diferencia de milisegundos a minutos
  const diferenciaMinutos = diferenciaMs / (1000 * 60);  
  console.log("(-1 * diferenciaMinutos) ", (-1 * diferenciaMinutos));
    // Comprobar si la diferencia es mayor a 20 minutos
  if((-1 * diferenciaMinutos) > 20)  {
    return false;
  }else{
    return true;
  }    
}

  Guardar(Usuario: IUsuario): Promise<any> {
    console.log('Antes del servicio ', Usuario)  
    return this.http.post('https://localhost:7145/Usuario/Guardar', Usuario).toPromise();
  }

  Login(data: any): Promise<any> {
    console.log('Antes del servicio ', data)  
    return this.http.post('https://localhost:7145/Usuario/Login', data).toPromise();
  }

  Logout(){
    //Borrar local storage
  }

  GetWeather(): Promise<any> {
    return this.http.get<any>('https://localhost:7145/WeatherForecast/Get').toPromise();    
  } 

  CheckEmail(email: string): Observable<any> {    
    return this.http.get('https://localhost:7145/Usuario/CheckEmail'+  "/" +  email);
  }

  UpdateUsuario(Usuario: IUsuario): Observable<any> {    
    return this.http.put('https://localhost:7127/Usuario/UpdateUsuario', Usuario);
  }

  DeleteUsuario(UsuarioId: Number): Observable<any> {    
    return this.http.delete('https://localhost:7127/Usuario/DeleteUsuario'+  "/" + UsuarioId);
  }

  GetAllUsuarios(): Promise<any> {
    return this.http.get<any>('https://localhost:7127/Usuario/GetAllUsuarios').toPromise();    
  } 

  GetUsuarioByLastNames(lastNames: string): Observable<any> {    
    return this.http.get('https://localhost:7127/Usuario/GetUsuarioByLastNames'+  "/" + lastNames);
  }

  GetUsuarioById(idUsuario: number): Observable<any> { 
    console.log("Capa services / GetUsuarioById con el id " + idUsuario);   
    return this.http.get('https://localhost:7127/Usuario/GetUsuarioById'+  "/" + idUsuario);
  }
}
