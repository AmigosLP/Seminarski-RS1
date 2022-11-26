import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AboutUsComponent } from "./app/about-us/about-us.component";
import { CategoriesComponent } from "./app/categories/categories.component";
import { LoginComponent } from "./app/login/login.component";
import { SignUpComponent } from "./app/sign-up/sign-up.component";
import { SlideComponent } from "./app/slide/slide.component";

const routes: Routes = [
    {path:"",component: SlideComponent},
    {path:"aboutus",component: AboutUsComponent},
    {path:"categories",component:CategoriesComponent},
    {path:"signup",component:SignUpComponent},
    {path:"login",component:LoginComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }