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
          return this.http.post<Utilisateur>(host+"/AdminControler/AddUser",user)

     }
     deletUser(user:Utilisateur):Observable<void>{
          let host=environment.host;
          return this.http.delete<void>(host+"/AdminControler/Delet?login="+user.login)

     }
     searchUser(keyword:string):Observable<Utilisateur[]>{
          let host=environment.host;
          return this.http.get<Utilisateur[]>(host+"/AdminControler/search?name="+keyword)

     }
     apdateUser(user:Utilisateur):Observable<Utilisateur>{
          let host=environment.host;
          return this.http.put<Utilisateur>(host+"/AdminControler/UpdateUser?login="+user.login,user)

     }
     getUserbyid(login:string):Observable<Utilisateur>{
          let host=environment.host;
          return this.http.get<Utilisateur>(host+"/AdminControler/search?name="+login)
     }
    

     





}
