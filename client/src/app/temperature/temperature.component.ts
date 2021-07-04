import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ITemperatureResponse } from '../itemperature-response';
import { TemperatureType } from '../temperature-type';
import { TemperatureService } from '../temperature.service';

@Component({
  selector: 'app-temperature',
  templateUrl: './temperature.component.html',
  styleUrls: ['./temperature.component.scss']
})
export class TemperatureComponent {

  public tempTypes = TemperatureType;

  temperatureForm: FormGroup;
  resultTemperature: number | undefined;

  constructor(
    private _fb: FormBuilder,
    private _temperatureService: TemperatureService
  ) {
      this.temperatureForm = this._fb.group({
        from: ['Celsius'],
        to: ['Fahrenheit'],
        tempToConvert: [0, [
          Validators.required,
          Validators.pattern('^[1-9]\\d*(\\.\\d+)?$'),
          Validators.maxLength(10)]
        ]
      });
  }

  onSubmit() {
    this._temperatureService
        .convertTemperature(this.temperatureForm.value)
        .subscribe(
          (data:ITemperatureResponse) => this.resultTemperature = data.result
        );
  }
}
