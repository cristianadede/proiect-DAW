import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { User } from '../interfaces/user';
@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private baseUrl: string = environment.baseUrl;
  private publicHeaders = {
    headers : new HttpHeaders ({
      'content-type':'application/json',
      'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Headers': 'Content-Type',
      'Access-Control-Allow-Methods': 'GET,POST,OPTIONS,DELETE,PUT',
      
    }),
  };
  constructor(private http:HttpClient) { }

  login(data:User) {
    return this.http.post(this.baseUrl + 'api/auth/login', data, this.publicHeaders);
  }
}
