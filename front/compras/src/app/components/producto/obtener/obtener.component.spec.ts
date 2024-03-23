import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientModule } from '@angular/common/http';
import { ObtenerComponent } from './obtener.component';
import { ActivatedRoute, RouterModule } from '@angular/router'; 
import { of } from 'rxjs'; 
import { Router } from '@angular/router';
import { ProductoService } from '../../../data/producto.service';

describe('ObtenerComponent', () => {
  let component: ObtenerComponent;
  let fixture: ComponentFixture<ObtenerComponent>;
  let productoServiceSpy: jasmine.SpyObj<ProductoService>;
  let route: ActivatedRoute;
  let router: Router;

  beforeEach(async () => {
    const productoServiceSpyObj = jasmine.createSpyObj('ProductoService', ['GetMasBuscados', 'GetByName']);
    const fakeItems = [
      {
        idProducto: 'b961e5a0-fa58-4240-a635-7c4b16e1f1f0',
        nombre: 'Medias',
        referencia: 'M3',
        urlImagen: 'ProductosImagenes/M3.png',
        descripcion: 'Medias',
        color: 'Blanco',
        cantidad: 25,
        talla: '5',
        valor: 3000,
        esDeLosMasBuscados: true,
        paraSexo: 'Masculino'
      },
      {
        idProducto: '5fb7fa03-5219-4026-824e-85e6c3fc0776',
        nombre: 'Chaqueta',
        referencia: 'C3',
        urlImagen: 'ProductosImagenes/C3.png',
        descripcion: 'Chaqueta',
        color: 'Negro',
        cantidad: 15,
        talla: '14',
        valor: 140000,
        esDeLosMasBuscados: true,
        paraSexo: 'Masculino'
      }
    ];
    productoServiceSpyObj.GetMasBuscados.and.returnValue(of(fakeItems)); 
    productoServiceSpyObj.GetByName.and.returnValue(of([])); 

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
        },
        { provide: ProductoService, useValue: productoServiceSpyObj },
        { provide: Router, useValue: {} }
      ]
    })
    .compileComponents();
    
    // fixture = TestBed.createComponent(ObtenerComponent);
    // component = fixture.componentInstance;
    // fixture.detectChanges();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ObtenerComponent);
    component = fixture.componentInstance;
    productoServiceSpy = TestBed.inject(ProductoService) as jasmine.SpyObj<ProductoService>;
    route = TestBed.inject(ActivatedRoute);
    router = TestBed.inject(Router);
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should call ConsultarMasBuscados when parametroDeBusqueda is Masculino or Femenino', () => {
    // Arrange
    const parametroDeBusqueda = 'Masculino';
    const items = [
      {
        idProducto: 'b961e5a0-fa58-4240-a635-7c4b16e1f1f0',
        nombre: 'Medias',
        referencia: 'M3',
        urlImagen: 'ProductosImagenes/M3.png',
        descripcion: 'Medias',
        color: 'Blanco',
        cantidad: 25,
        talla: '5',
        valor: 3000,
        esDeLosMasBuscados: true,
        paraSexo: 'Masculino'
      },
      {
        idProducto: '5fb7fa03-5219-4026-824e-85e6c3fc0776',
        nombre: 'Chaqueta',
        referencia: 'C3',
        urlImagen: 'ProductosImagenes/C3.png',
        descripcion: 'Chaqueta',
        color: 'Negro',
        cantidad: 15,
        talla: '14',
        valor: 140000,
        esDeLosMasBuscados: true,
        paraSexo: 'Masculino'
      }
    ];
    productoServiceSpy.GetMasBuscados.and.returnValue(of(items));

    // Act
    route.snapshot.params['parametroDeBusqueda'] = parametroDeBusqueda;
    fixture.detectChanges();

    // Assert    
    expect(productoServiceSpy.GetMasBuscados).toHaveBeenCalledWith(parametroDeBusqueda);
    expect(component.items).toEqual(items);
  });

});
