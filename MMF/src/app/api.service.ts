import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Place } from './place';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  apiUrl = 'https://localhost:44388/api/place';

  constructor(private http: HttpClient) {}

  GetPlaces(): Observable<any> {
    return this.http.get(`${this.apiUrl}`, {responseType: 'json'});
  }

  GetPlace(id: number): Observable<any> {
    return this.http.get(`${this.apiUrl}?id=${id}`, {responseType: 'json'});
  }
}
