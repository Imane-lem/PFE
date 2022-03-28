import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { catchError, map, Observable, of, startWith } from 'rxjs';
import { Client } from 'src/app/Models/Client.medel';
import { ClientServices } from 'src/app/Services/Client.service';
import { AppDataState, DataStateEnum } from 'src/app/State/user.state';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent implements OnInit {

  client$!:Observable<AppDataState<Client[]>>;
  readonly DataStateEnum=DataStateEnum;

  constructor(private clientservice:ClientServices,private router:Router) { }

  ngOnInit(): void {
  }

  OnGetALLClients(){
    this.client$=
    this.clientservice.getallClients().pipe(
      map(data=>{
        return({datastate:DataStateEnum.LOADED,data:data}) }),
        startWith({datastate:DataStateEnum.LOADING}),
        catchError(err=>of({datastate:DataStateEnum.ERROR,errMessage:err.message}))

    );

  }
  onSearch(dataform:any){
    this.client$=
    this.clientservice.searchClient(dataform.keyword).pipe(
      map(data=>{
        return({datastate:DataStateEnum.LOADED,data:data})
      }),
      startWith({datastate:DataStateEnum.LOADING}),
      catchError(err=>of({datastate:DataStateEnum.ERROR,errMessage:err.message}))

    );

  }
  onUpdate(C:Client){
    this.router.navigateByUrl("/editclient/"+C.clientId)

  }
  onDelet(C:Client){
    let v=confirm("etes vous sur?");
    if(v==true)
    this.clientservice.deletClient(C).subscribe(
      data=>{
        this.OnGetALLClients();

  });
}
 

 




  }



