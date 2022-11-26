import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private loginUrl:string="https://localhost:44333/api/Users"
  constructor(private http:HttpClient) { }

  login(loginObj:any)
  {
    return this.http.post<any>(`${this.loginUrl}`,loginObj);
  }
  

}
