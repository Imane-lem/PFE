import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './home/home.component';
import { AdministrationComponent } from './administration/administration.component';
import { AddUserComponent } from './administration/add-user/add-user.component';
import { EditUserComponent } from './administration/edit-user/edit-user.component';
import { FournisseurComponent } from './Fournisseur/fournisseur/fournisseur.component';
import { AddfourComponent } from './Fournisseur/addfour/addfour.component';
import { EditfourniComponent } from './Fournisseur/editfourni/editfourni.component';
import { ClientComponent } from './Client/client/client.component';
import { AddClientComponent } from './Client/add-client/add-client.component';
import { EditClientComponent } from './Client/edit-client/edit-client.component';




@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    AdministrationComponent,
    AddUserComponent,
    EditUserComponent,
    FournisseurComponent,
    AddfourComponent,
    EditfourniComponent,
    ClientComponent,
    AddClientComponent,
    EditClientComponent,
    
   
   
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
