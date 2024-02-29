import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IUsuario } from '../../../data/IUsuario';
import { UsuarioService } from '../../../data/usuario.service';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-guardar-usuario',
  templateUrl: './guardar-usuario.component.html',
  styleUrl: './guardar-usuario.component.css'
})
export class GuardarUsuarioComponent implements OnInit {
  myForm!: FormGroup;    
  submitted = false; 

  constructor(private formBuilder: FormBuilder, private usuarioService: UsuarioService) { }

  iniciarFormulario(){
    this.myForm = this.formBuilder.group({           
      //Temporary Guid
      IdUsuario:['58650f7d-2495-4a2c-9092-493dc2ecda63'],          
      Nombres: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],
      Apellidos: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],
      CorreoElectronico: ['', [Validators.required, Validators.pattern(/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/), Validators.minLength(3), Validators.maxLength(30)]],
      TipoDeDocumento: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],
      NumeroDeDocumento: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(16)]],                    
      Contrasena: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],   
      Genero: ['Masculino', Validators.required],
      Direccion: ['', [Validators.required, Validators.minLength(7), Validators.maxLength(30)]],                    
      Rol: ['Comprador']
    });
  }

  ngOnInit(): void {
    this.iniciarFormulario();
  }

  get form(): { [key: string]: AbstractControl; }
  {
      return this.myForm.controls;
  }

  onReset(): void {
    this.submitted = false;
    this.myForm.reset();
  }

  getWeather(): void {
    this.usuarioService.GetWeather().then((response: any) => {
      console.log('response GetWeather', response);                     
    })
    .catch((error: any) => {
      console.error(': ', error);
    }) 
  }

  onSubmit() {    
    this.submitted = true;
    console.log("Form value ", this.myForm.value);

    if (this.myForm.invalid) {
      console.log('Error')          
      return
    }         
    
    this.usuarioService.Guardar(this.myForm.value).then((response: any) => {
      console.log('response', response);               
    })
    .catch((error: any) => {
      console.error(': ', error);
    })     
               
  }  
}
