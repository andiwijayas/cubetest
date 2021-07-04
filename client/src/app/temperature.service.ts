import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TemperatureType } from './temperature-type';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { ITemperatureResponse } from './itemperature-response';
import { ITemperatureRequest } from './itemperature-request';

@Injectable({
  providedIn: 'root'
})
export class TemperatureService {
  private apiUrl:string = 'http://localhost:5000/api/temperature'

  constructor(private http:HttpClient) { }

  convertTemperature(request: ITemperatureRequest)
    : Observable<ITemperatureResponse> {
    let url = this.apiUrl
                .replace('{from}', request.from)
                .replace('{to}', request.to)
                .replace('{value}', String(request.tempToConvert));

    return this.http.post<ITemperatureResponse>(url, request)
                      .pipe (
                        retry(1),
                        catchError(this.handleError)
                      );

  }

  private handleError(error: any) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      errorMessage = `Error: ${error.error.message}`;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(errorMessage);
  }
}
