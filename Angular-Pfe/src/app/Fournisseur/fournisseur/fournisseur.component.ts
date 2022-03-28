import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { catchError, map, Observable, of, startWith } from 'rxjs';
import { Fournisseur } from 'src/app/Models/Fournisseur.model';
import { FournisseurService } from 'src/app/Services/Fournisseur.service';
import { AppDataState, DataStateEnum } from 'src/app/State/user.state';

@Component({
  selector: 'app-fournisseur',
  templateUrl: './fournisseur.component.html',
  styleUrls: ['./fournisseur.component.css']
})
export class FournisseurComponent implements OnInit {
  fourni$!:Observable<AppDataState<Fournisseur[]>>;
  readonly DataStateEnum=DataStateEnum;


  constructor( private fourniservice:FournisseurService,private router:Router) { }

  ngOnInit(): void {
  }

  OnGetALLFourni(){
    this.fourni$=
    this.fourniservice.getallfournisseur().pipe(
      map(data=>{
        console.log(data);
        return( {datastate:DataStateEnum.LOADED,data:data })
                }
         ),
      startWith({datastate:DataStateEnum.LOADING}),
      catchError(err=>of({datastate:DataStateEnum.ERROR,errMessage:err.message}))
      );
    
  }
  onDelet(f:Fournisseur){
    let v=confirm("etes vous sur?");
    if(v==true)
    this.fourniservice.deletFournisseur(f).subscribe(
      data=>{
       
       this.OnGetALLFourni();
  })


  }
  onUpdate(f:Fournisseur){
    this.router.navigateByUrl("/editfourni/"+f.id_f);

  }
  onSearch(dataform:any){
    this.fourni$=
    this.fourniservice.searchFouri(dataform.keyword).pipe(
      map(data=>{
        return( {datastate:DataStateEnum.LOADED,data:data })}),
        startWith({datastate:DataStateEnum.LOADING}),
        catchError(err=>of({datastate:DataStateEnum.ERROR,errMessage:err.message}))
        
    )
  }



}
