import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ResponseModel } from '../Models/ResponseModel';
import { LoginService } from '../Services/Login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    loginForm!:FormGroup;
   
  constructor( private formbuilder:FormBuilder,private loginservice:LoginService,private router:Router) { }

  ngOnInit(): void {

    this.loginForm=this.formbuilder.group({
      login:["",Validators.required],
      password:["",Validators.required],
     
    })
  }

  onSabmit(){
   
    
    this.loginservice.login(this.loginForm.value).subscribe(data=>{
      console.log(data);
      
      if(data.statusCode =="000")
      {
        console.log(data);
        this.router.navigate(['home']);
      }
      else
      {
        console.log(data.statusLabel);
      }
      localStorage.setItem("data",JSON.stringify(data));
          

    })

  }

}
