import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Utilisateur } from '../Models/Utilisateur';
import { AdministrationService } from '../Services/Administration.service';

@Component({
  selector: 'app-administration',
  templateUrl: './administration.component.html',
  styleUrls: ['./administration.component.css']
})
export class AdministrationComponent implements OnInit {
  User?:Utilisateur[];
 // mydata=JSON.parse(localStorage.getItem('data'))
  constructor( 
    private adminservice:AdministrationService,
    private router: Router
    ) { }

  ngOnInit(): void {
    let data: any = localStorage.getItem("data");
    var result = JSON.parse(data);
    console.log(result.isAdmin);
    if(!result.isAdmin){
      this.router.navigate(['home']);
    }
    
  }
  onGetAllUsers(){
    this.adminservice.getAllUser().subscribe(data=>{
      this.User=data;
    },err=>{
      console.log(err);
    })
    }

  }




