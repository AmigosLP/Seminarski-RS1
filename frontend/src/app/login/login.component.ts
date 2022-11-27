import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../services/auth.service';
import { NgToastService } from 'ng-angular-popup';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(
    private fb:FormBuilder,
    private auth:AuthService,
    private toast:NgToastService,
    private router:Router
  ) { }
  prijava:any

  ngOnInit(): void {
    
    this.prijava=this.fb.group({
      "username":new FormControl(null,[Validators.required,Validators.pattern('[A-Za-z]*')]),
      "password":new FormControl(null,[Validators.required])

    });

  }
  prijavaKorisnika()
  {
    this.auth.login(this.prijava.value)
    .subscribe({
      next:(res)=>{
       // alert(res.message);
        this.toast.success({detail:"SUCCESS",summary:res.message,duration:5000});
        this.prijava.reset();
        this.router.navigate(['mainpage'])
      },
      error:(err)=>
      {
        //alert(err?.error.message);
        this.toast.error({detail:"ERROR",summary:err?.error.message,duration:5000});
      }
    })
  }

  get username(): FormControl {
    return this.prijava.get('username') as FormControl;
  }//username

  get password() : FormControl {
    return this.prijava.get('password') as FormControl;
  }//password
}
