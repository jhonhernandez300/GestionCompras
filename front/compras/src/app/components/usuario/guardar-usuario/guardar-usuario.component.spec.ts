import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';
import { GuardarUsuarioComponent } from './guardar-usuario.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

describe('GuardarUsuarioComponent', () => {
  let component: GuardarUsuarioComponent;
  let fixture: ComponentFixture<GuardarUsuarioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [GuardarUsuarioComponent],
      imports: [HttpClientModule, ReactiveFormsModule, FormsModule],
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(GuardarUsuarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
     expect(component).toBeTruthy();
  });
});
