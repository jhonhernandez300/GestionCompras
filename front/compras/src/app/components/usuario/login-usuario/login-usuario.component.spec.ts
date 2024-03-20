import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';
import { LoginUsuarioComponent } from './login-usuario.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

describe('LoginUsuarioComponent', () => {
  let component: LoginUsuarioComponent;
  let fixture: ComponentFixture<LoginUsuarioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LoginUsuarioComponent],
      imports: [HttpClientModule, ReactiveFormsModule, FormsModule],
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LoginUsuarioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
