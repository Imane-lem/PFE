import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { catchError, map, Observable, of, startWith } from 'rxjs';
import { Utilisateur } from '../Models/Utilisateur';
import { AdministrationService } from '../Services/Administration.service';
import { AppDataState, DataStateEnum } from '../State/user.state';

@Component({
  selector: 'app-administration',
  templateUrl: './administration.component.html',
  styleUrls: ['./administration.component.css']
})
export class AdministrationComponent implements OnInit {
  User!:Utilisateur[];
  User$!:Observable<AppDataState<Utilisateur[]>>;
   userd!:Utilisateur;
   readonly DataStateEnum=DataStateEnum;

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
   this.User$=
    this.adminservice.getAllUser().pipe(
      map(data=>{ 
        return( {datastate:DataStateEnum.LOADED,data:data })}),
      startWith({datastate:DataStateEnum.LOADING}),
      catchError(err=>of({datastate:DataStateEnum.ERROR,errMessage:err.message}))
    );
    }


    onDelet(u:Utilisateur){
      let v=confirm("etes vous sur?");
      if(v==true)
      this.adminservice.deletUser(u).subscribe(
        data=>{
         this.onGetAllUsers();
    })
  }
  onSearch(dataform:any){
    this.User$=
    this.adminservice.searchUser(dataform.keyword).pipe(
      map(data=>{
        return( {datastate:DataStateEnum.LOADED,data:data })}),
      startWith({datastate:DataStateEnum.LOADING}),
      catchError(err=>of({datastate:DataStateEnum.ERROR,errMessage:err.message}))
    );

}
 onUpdate(u:Utilisateur){
   this.router.navigateByUrl("/edituser/"+u.login);

}

  



}
