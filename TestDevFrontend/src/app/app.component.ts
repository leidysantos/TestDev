import {Component, OnInit} from '@angular/core';
import {LibrosService} from '../services/libros.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'TestDevFrontend';

  constructor(private servicio: LibrosService) {
  }
  ngOnInit(): void {
    this.servicio.getDatos().subscribe((resp: any) => {
      console.log(resp);
    });
  }
}
