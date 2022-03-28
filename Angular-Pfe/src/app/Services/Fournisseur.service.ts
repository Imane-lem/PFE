import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import{Fournisseur}from "../Models/Fournisseur.model";

@Injectable({providedIn:"root"})
export class FournisseurService{
    constructor(private http:HttpClient){}  
    
    getallfournisseur():Observable<Fournisseur[]>{
        let host=environment.host;
         return this.http.get<Fournisseur[]>(host+"/Fournisseur/Getfournisseur")

    }
    getFourniByid(id:number):Observable<Fournisseur>{
        let host=environment.host;
       return this.http.get<Fournisseur>(host+"/Fournisseur/getById?id="+id)

    }
    AddFourni(F:Fournisseur):Observable<Fournisseur>{
        let host=environment.host;
        return this.http.post<Fournisseur>(host+"/Fournisseur/AddFournisseur",F)

    }
    deletFournisseur(F:Fournisseur):Observable<Fournisseur>{
        let host=environment.host;
        return this.http.delete<Fournisseur>(host+"/Fournisseur/Delet?id="+F.id_f)

    }
     updateFournisseur(F:Fournisseur):Observable<Fournisseur>{
         let host=environment.host;
         return this.http.put<Fournisseur>(host+"/Fournisseur/UpdateFournisseur?id="+F.id_f,F)

     }
     searchFouri(keyword:string):Observable<Fournisseur[]>{
         let host=environment.host;
         return this.http.get<Fournisseur[]>(host+"/Fournisseur/search?name="+keyword)
     }
    



















}