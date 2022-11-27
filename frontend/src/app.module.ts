import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app/app.component';
import { AboutUsComponent } from './app/about-us/about-us.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SlideComponent } from './app/slide/slide.component';
import { AppRoutingModule } from './app-routing.components';
import { CategoriesComponent } from './app/categories/categories.component';
import { SignUpComponent } from './app/sign-up/sign-up.component';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './app/login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { NgToastModule } from 'ng-angular-popup';
import { MainPageComponent } from './app/user-page/main-page.component' 



@NgModule({
  declarations: [
    AppComponent,
    AboutUsComponent,
    SlideComponent,
    CategoriesComponent,
    SignUpComponent,
    LoginComponent,
    MainPageComponent
  ],
  imports: [
    BrowserModule,
    NgbModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgToastModule
    
    
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
