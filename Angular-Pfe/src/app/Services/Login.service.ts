import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { ResponseModel } from "../Models/ResponseModel";
import { User } from "../Models/user";

@Injectable({providedIn:"root"})

export class LoginService{
    constructor(private http:HttpClient){}

      login(user: User){
          let host=environment.host;
          return this.http.post<ResponseModel>(host+"/User/login",user);
      }










}