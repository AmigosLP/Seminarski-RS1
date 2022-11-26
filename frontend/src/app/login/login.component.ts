import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(
    private fb:FormBuilder,
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

  }

  get username(): FormControl {
    return this.prijava.get('username') as FormControl;
  }//username

  get password() : FormControl {
    return this.prijava.get('password') as FormControl;
  }//password
}
