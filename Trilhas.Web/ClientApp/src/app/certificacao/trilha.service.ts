import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TrilhaService {

  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get(`${environment.endpoint}/trilha`);
  }

  add(entity: any) {
    return this.http.post(`${environment.endpoint}/trilha`, entity);
  }

  update(id: string, entity: any) {
    return this.http.put(`${environment.endpoint}/trilha/${id}`, entity);
  }

  delete(id: string) {
    return this.http.delete(`${environment.endpoint}/trilha/${id}`);
  }
}
