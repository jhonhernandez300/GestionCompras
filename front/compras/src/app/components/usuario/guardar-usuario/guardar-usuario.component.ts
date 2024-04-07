import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IUsuario } from '../../../data/IUsuario';
import { UsuarioService } from '../../../data/usuario.service';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-guardar-usuario',
  templateUrl: './guardar-usuario.component.html',
  styleUrl: './guardar-usuario.component.css'
})
export class GuardarUsuarioComponent implements OnInit {
  myForm!: FormGroup;    
  submitted = false; 
  emailChecked = false;

  constructor(
    private formBuilder: FormBuilder, 
    private usuarioService: UsuarioService    
  ) { }

  iniciarFormulario(){
    this.myForm = this.formBuilder.group({           
      //Temporary Guid
      IdUsuario:['58650f7d-2495-4a2c-9092-493dc2ecda63'],          
      Nombres: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],
      Apellidos: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],
      CorreoElectronico: ['', [Validators.required, Validators.pattern(/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/), Validators.minLength(5), Validators.maxLength(30)]],
      TipoDeDocumento: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],
      NumeroDeDocumento: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(16)]],                    
      Contrasena: ['', [
        Validators.required,
        Validators.minLength(5),
        Validators.maxLength(30),
        this.validarContrasena // Agregamos nuestra validación personalizada
      ]],
      Genero: ['Masculino', [Validators.required, Validators.minLength(8), Validators.maxLength(9)]],
      Direccion: ['', [Validators.required, Validators.minLength(7), Validators.maxLength(30)]],                    
      Rol: ['Comprador']
    });
  }

  ngOnInit(): void {
    this.iniciarFormulario();
  }

  validarContrasena(control: any) {
    const contrasena = control.value;
    const tieneMayuscula = /[A-Z]/.test(contrasena);
    const tieneMinuscula = /[a-z]/.test(contrasena);
    const tieneNumero = /\d/.test(contrasena);

    const esValido = tieneMayuscula && tieneMinuscula && tieneNumero;

    return esValido ? null : { 'contrasenaInvalida': true };
  }

  get form(): { [key: string]: AbstractControl; }
  {
      return this.myForm.controls;
  }

  onReset(): void {
    this.submitted = false;
    this.myForm.reset();
    this.emailChecked = false;
  }

  onSubmit() {        
    this.submitted = true;
    console.log("Form value ", this.myForm.value);    
    this.EmailChecked();

    if (this.myForm.invalid) {
      console.log('Error de validación')          
      return
    }             
    
    this.usuarioService.Guardar(this.myForm.value).then((response: any) => {
      console.log('response', response);               
    })
    .catch((error: any) => {
      console.error(': ', error);      
    })                    
  }  
  
  checkEmailExists(email: string): Observable<any> {
    return this.usuarioService.CheckEmail(email);
  }

  EmailChecked(){
    console.log('En EmailChecked');    
    if(this.emailChecked == false){
      const email = this.myForm.get('CorreoElectronico')?.value;
      console.log(email);
      if (email) {
        this.checkEmailExists(email).subscribe(
          (response) => {                    
            console.log('Correo electrónico ya existe:', response);          
            this.myForm.get('CorreoElectronico')?.setErrors({ 'correoExiste': true });            
          },
          (error) => {          
            console.error('Error al verificar el correo electrónico:', error);                  
          }
        );
        this.emailChecked = true;
      }      
    }
  }
  
  onPasswordFocus() {
    this.EmailChecked();
  }

  
}

