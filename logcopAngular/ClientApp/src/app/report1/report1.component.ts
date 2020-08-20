import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-report1',
  templateUrl: './report1.component.html',
  styleUrls: ['./report1.component.css']
})
export class GeomagnetismComponent {
  public mags: Geomagnetism[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Geomagnetism[]>(baseUrl + 'geomagnetism').subscribe(result => {
      this.mags = result;
    }, error => console.error(error));
  }


}

interface Geomagnetism {
  date: string;
  magnetos: number;
  electroUnits: number;
  summary: string;
}
