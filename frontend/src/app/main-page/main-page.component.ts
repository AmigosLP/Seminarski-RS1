import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import * as $ from 'jquery'
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
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent implements OnInit {
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
  
  ngOnInit() {
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
