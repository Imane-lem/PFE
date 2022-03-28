import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddUserComponent } from './administration/add-user/add-user.component';
import { AdministrationComponent } from './administration/administration.component';
import { EditUserComponent } from './administration/edit-user/edit-user.component';
import { AddClientComponent } from './Client/add-client/add-client.component';
import { ClientComponent } from './Client/client/client.component';
import { EditClientComponent } from './Client/edit-client/edit-client.component';
import { AddfourComponent } from './Fournisseur/addfour/addfour.component';
import { EditfourniComponent } from './Fournisseur/editfourni/editfourni.component';
import { FournisseurComponent } from './Fournisseur/fournisseur/fournisseur.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [

  {path:'',redirectTo:'login',pathMatch:'full'},
  {path:"login",component:LoginComponent},
  {path:"home",component:HomeComponent},
  {path:'admin',component:AdministrationComponent},
  {path:'adduser',component:AddUserComponent},
  {path:'edituser/:uderId',component:EditUserComponent},
  {path:'fournisseur',component:FournisseurComponent},
  {path:'addfourni',component:AddfourComponent},
  {path:'editfourni/:id_f',component:EditfourniComponent},
  {path:'client',component:ClientComponent},
  {path:'addclient',component:AddClientComponent},
  {path:'editclient/: clientId',component:EditClientComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
