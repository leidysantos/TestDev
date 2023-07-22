import {Component, OnInit} from '@angular/core';
import {LibrosService} from '../services/libros.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Leidy';
  listaLibros: any;
  listaAutores: any;
  listaEditoriales: any;

  constructor(private servicio: LibrosService) {
  }
  ngOnInit(): void {
    this.listarLibros();
    this.listarEditoriales();
    this.listarAutores();
  }

  listarLibros(){
    this.servicio.getLibros().subscribe((resp: any) => {
      this.listaLibros = resp;
    });
  }

  listarEditoriales(){
    this.servicio.getEditoriales().subscribe((resp: any) => {
      this.listaEditoriales = resp;
    });
  }

  listarAutores(){
    this.servicio.getAutores().subscribe((resp: any) => {
      this.listaAutores = resp;
    });
  }
}
