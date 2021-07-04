import { Component } from '@angular/core';
import { TemperatureType } from './temperature-type';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  tempTypes = TemperatureType;

  title = 'client';
}
