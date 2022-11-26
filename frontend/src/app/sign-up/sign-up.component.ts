import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators} from '@angular/forms';


@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  constructor() { }

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
    console.log(this.signUp.value);

    if (this.signUp.valid) {
      alert(`Thank You ${this.signUp.value.firstName}:)`);
      this.signUp.reset();//reset form value
    }
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
