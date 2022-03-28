import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { Client } from "../Models/Client.medel";

@Injectable({providedIn:"root"})
export class ClientServices{
    constructor(private http:HttpClient){}

    getallClients():Observable<Client[]>{
        let host=environment.host;
         return this.http.get<Client[]>(host+"/Client/GetClient")

    }
    getClientByid(id:number):Observable<Client>{
        let host=environment.host;
       return this.http.get<Client>(host+"/Client/getById?id="+id)

    }
    AddClient(C:Client):Observable<Client>{
        let host=environment.host;
        return this.http.post<Client>(host+"/Client/AddClient",C)

    }
    deletClient(C:Client):Observable<Client>{
        let host=environment.host;
        return this.http.delete<Client>(host+"/Client/Delet?id="+C.clientId)

    }
     updateClient(C:Client):Observable<Client>{
         let host=environment.host;
         return this.http.put<Client>(host+"/Client/UpdateClient?id="+C.clientId,C)

     }
     searchClient(keyword:string):Observable<Client[]>{
         let host=environment.host;
         return this.http.get<Client[]>(host+"/Client/search?name="+keyword)
     }
    

}