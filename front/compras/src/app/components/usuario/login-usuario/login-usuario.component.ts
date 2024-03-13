import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IUsuario } from '../../../data/IUsuario';
import { UsuarioService } from '../../../data/usuario.service';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-usuario',
  templateUrl: './login-usuario.component.html',
  styleUrl: './login-usuario.component.css'
})
export class LoginUsuarioComponent implements OnInit {
  myForm!: FormGroup;    
  submitted = false; 

  constructor(
    private formBuilder: FormBuilder, 
    private usuarioService: UsuarioService,
    private router: Router
  ) { }
  
  iniciarFormulario(){
    this.myForm = this.formBuilder.group({                
      CorreoElectronico: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],                      
      Contrasena: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]]         
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

  onSubmit() {    
    this.submitted = true;
    console.log("Form value ", this.myForm.value);

    if (this.myForm.invalid) {
      console.log('Error')          
      return
    }     
    
    //this.form.get('IdComprador')?.setValue("58650f7d-2495-4a2c-9092-493dc2ecda63");
    //David@gmail.com Ospina1
    this.usuarioService.Login(this.myForm.value).then((response: any) => {
      console.log('response', response.result);               
      localStorage.setItem('token', response.result);
      const currentDate = new Date();
      const dateString = currentDate.toISOString();        
      localStorage.setItem('last date', dateString);
      this.router.navigate(['/producto-obtener']);
    })
    .catch((error: any) => {
      console.error(': ', error);
    })    
             
  }  
}
