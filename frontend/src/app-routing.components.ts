import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AboutUsComponent } from "./app/about-us/about-us.component";
import { CategoriesComponent } from "./app/categories/categories.component";
import { LoginComponent } from "./app/login/login.component";
import { SignUpComponent } from "./app/sign-up/sign-up.component";
import { SlideComponent } from "./app/slide/slide.component";
import { MainPageComponent } from "./app/main-page/main-page.component";
import { CustomizeProfileComponent } from "./app/customize-profile/customize-profile.component";

const routes: Routes = [
    {path:"",component: SlideComponent},
    {path:"aboutus",component: AboutUsComponent},
    {path:"categories",component:CategoriesComponent},
    {path:"signup",component:SignUpComponent},
    {path:"login",component:LoginComponent},
    {path:"mainpage",component:MainPageComponent},
    {path:"customize-profile",component:CustomizeProfileComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }