import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AboutUsComponent } from "./about-us/about-us.component";
import { CategoriesComponent } from "./categories/categories.component";
import { SlideComponent } from "./slide/slide.component";

const routes: Routes = [
    {path:"",component: SlideComponent},
    {path:"aboutus",component: AboutUsComponent},
    {path:"categories",component:CategoriesComponent},
    {path:"**", redirectTo: '/'}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }