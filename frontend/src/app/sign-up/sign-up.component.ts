import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators} from '@angular/forms';
import { Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import { AuthService } from '../services/auth.service';


@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  constructor(private auth:AuthService,private router:Router,private toast:NgToastService) { }

  signUp = new FormGroup({
    "firstName": new FormControl(null, [Validators.required, Validators.pattern('[a-zA-Z]*')]),
    "lastName": new FormControl(null, [Validators.required, Validators.pattern('[a-zA-Z]*')]),
    "email": new FormControl(null, [Validators.required, Validators.email]),
    "username":new FormControl(null,[Validators.required,Validators.pattern('[A-Za-z]*')]),
    "password":new FormControl(null,[Validators.required]),
    "genderName":new FormControl(null,[Validators.required])
    
  });

  ngOnInit(): void {
  }
  //submit function
  submitData() {
    this.auth.signUp(this.signUp.value)
    .subscribe({
      next:(res=>{
        //alert(res.message);
        this.toast.success({detail:"SUCCESS",summary:res.message,duration:5000});
        this.signUp.reset();
        this.router.navigate(['login'])

      }),
      error:(err=>{
        //alert(err?.error.message);
        this.toast.error({detail:"ERROR",summary:err?.error.message,duration:5000});
      })
    })

  }

  get firstName(): FormControl {
    return this.signUp.get('firstName') as FormControl;
  }

  get lastName() : FormControl {
    return this.signUp.get('lastName') as FormControl;
  }//lastName
  get email() : FormControl { 
    return this.signUp.get('email') as FormControl; 
}//email
get username(): FormControl {
  return this.signUp.get('username') as FormControl;
  
}
get password(): FormControl {
  return this.signUp.get('password') as FormControl;
}
get genderName(): FormControl {
  return this.signUp.get('genderName') as FormControl;
}



}
