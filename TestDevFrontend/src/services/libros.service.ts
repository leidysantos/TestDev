import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LibrosService {

  private apiUrl = 'http://localhost:5001/api';
  constructor(private http: HttpClient) { }

  getLibros() {
    return this.http.get<any[]>(`${this.apiUrl}/libros`);
  }

  getAutores() {
    return this.http.get<any[]>(`${this.apiUrl}/autores`);
  }

  getEditoriales() {
    return this.http.get<any[]>(`${this.apiUrl}/editoriales`);
  }
}
