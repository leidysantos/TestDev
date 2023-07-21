import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LibrosService {

  private apiUrl = 'http://localhost:5001/aoi/nombres';
  constructor(private http: HttpClient) { }

  getDatos() {
    return this.http.get<any[]>(this.apiUrl);
  }
}
