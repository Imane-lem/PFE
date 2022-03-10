import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";

import{Utilisateur}from "../Models/Utilisateur";

@Injectable({providedIn:"root"})

export class AdministrationService {
     constructor(private http:HttpClient){}

     getAllUser():Observable< Utilisateur[]>{
          let host=environment.host;
         return this.http.get< Utilisateur[]>(host+"/AdminControler/GetUsers")
     }
     addUser(user:Utilisateur):Observable<Utilisateur>{
          let host=environment.host;
          return this.http.post<Utilisateur>(host+"/AdminControler/AddUser",+user)

     }
     





}
