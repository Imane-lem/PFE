import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddUserComponent } from './administration/add-user/add-user.component';
import { AdministrationComponent } from './administration/administration.component';
import { EditUserComponent } from './administration/edit-user/edit-user.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [

  {path:'',redirectTo:'login',pathMatch:'full'},
  {path:"login",component:LoginComponent},
  {path:"home",component:HomeComponent},
  {path:'admin',component:AdministrationComponent},
  {path:'adduser',component:AddUserComponent},
  {path:'edituser/:login',component:EditUserComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
