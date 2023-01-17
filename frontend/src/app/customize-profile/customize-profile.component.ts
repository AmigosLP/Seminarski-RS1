import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { read } from '@popperjs/core';
import { environment } from 'src/environments/environment';
import {ImageConverter} from '../helpers/ImageConverter';

@Component({
  selector: 'app-customize-profile',
  templateUrl: './customize-profile.component.html',
  styleUrls: ['./customize-profile.component.css']
})
export class CustomizeProfileComponent implements OnInit {
  player:any;
  event:any;

  imageFile:File|undefined;

  constructor(private http: HttpClient) {
  
   }

  ngOnInit(): void {
  }

  url="./assets/karlo.jpg";

    onselectFile(e){
    if(e.target.files)
    {
      var reader = new FileReader();
      reader.readAsDataURL(e.target.files[0]);
      reader.onload=(event:any)=>
      {
        this.imageFile = e.target.files[0];
        this.url=event.target.result;
      }
    }
  }

  async onProfileImageSubmit() {

      //@ts-ignore
      let image=await ImageConverter.ToBase64(this.imageFile);
      /*let ImagineConversion=async () => 
      {
          image = <string>await ImageConverter.ToBase64(<File>this.imageFile);
      }*/

     // await ImagineConversion();
      console.log(image);
      this.http.post(`${environment.api_url}/api/Players/updateProfileImage`, image).subscribe();

  }
}
