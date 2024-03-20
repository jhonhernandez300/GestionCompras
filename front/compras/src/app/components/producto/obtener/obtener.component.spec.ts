import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';
import { ObtenerComponent } from './obtener.component';
import { ActivatedRoute, RouterModule } from '@angular/router'; 
import { of } from 'rxjs'; 

describe('ObtenerComponent', () => {
  let component: ObtenerComponent;
  let fixture: ComponentFixture<ObtenerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ObtenerComponent],      
      imports: [HttpClientModule, RouterModule.forRoot([])],
      providers: [
        {
          provide: ActivatedRoute,
          useValue: {
            snapshot: {
              params: { parametroDeBusqueda: 'Masculino' } // Establece el valor de los parámetros de la instantánea
            }
          }
        }
      ]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ObtenerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
