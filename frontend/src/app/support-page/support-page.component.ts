import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import {
  faUser,
  faHome,
  faFileInvoice,
  faPlane,
  faHashtag,
  faArrowCircleRight,
  
} from '@fortawesome/free-solid-svg-icons';
import { arrow } from '@popperjs/core';
@Component({
  selector: 'app-support-page',
  templateUrl: './support-page.component.html',
  styleUrls: ['./support-page.component.css']
})
export class SupportPageComponent implements OnInit {
  isSidebarVisible = false;


  readonly icons = {
    user: faUser,
    home: faHome,
    invoice: faFileInvoice,
    service: faPlane,
    admin: faArrowCircleRight,
    social: faHashtag,
    
    
  }
  constructor(private auth:AuthService) { }
  ngOnInit()  {
    console.log(faUser);
  }

  toggleSidebar() {
    this.isSidebarVisible = !this.isSidebarVisible;
  }
  logout()
  {
    this.auth.signOut();
  }
}

  






  
  
 

  


