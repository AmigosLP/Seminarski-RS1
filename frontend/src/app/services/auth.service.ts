import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private loginUrl:string="https://localhost:44333/api/Users"
  private signUpUrl:string="https://localhost:44333/api/Players"
  
  constructor(private http:HttpClient,private router:Router) { }

  login(loginObj:any)
  {
    return this.http.post<any>(`${this.loginUrl}`,loginObj);
  }
  signUp(signUpObj:any)
  {
    return this.http.post<any>(`${this.signUpUrl}`,signUpObj);
  }
  signOut()
  {
    localStorage.clear();
    this.router.navigate(['login']);
  }

}
