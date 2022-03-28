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
          return this.http.delete<void>(host+"/AdminControler/Delet?id="+user.uderId)

     }
     searchUser(keyword:string):Observable<Utilisateur[]>{
          let host=environment.host;
          return this.http.get<Utilisateur[]>(host+"/AdminControler/search?name="+keyword)

     }
     apdateUser(user:Utilisateur):Observable<Utilisateur>{
          let host=environment.host;
          console.log(user);
          return this.http.put<Utilisateur>(host+"/AdminControler/UpdateUser?id="+user.uderId,user)

     }
     getUserbyid(id:number):Observable<Utilisateur>{
          let host=environment.host;
          return this.http.get<Utilisateur>(host+"/AdminControler/getbyid?id="+id)
     }
    

     





}
