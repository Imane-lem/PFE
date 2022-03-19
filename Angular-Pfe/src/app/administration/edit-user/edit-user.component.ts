import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { AdministrationService } from 'src/app/Services/Administration.service';

@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent implements OnInit {
  Userid!:string;
  userformgroup!:FormGroup;

  constructor( private adminservice:AdministrationService,private fb:FormBuilder,private activateroot:ActivatedRoute) 
  {
   this.Userid=this.activateroot.snapshot.params['login'];
   console.log(this.Userid);
   }

  ngOnInit(): void {
    this.adminservice.getUserbyid(this.Userid).subscribe(user=>{
      this.userformgroup=this.fb.group({
      login:[user.login,Validators.required],
      password:[user.password,Validators.required],
      name:[user.name,Validators.required],
      prenom:[user.prenom,Validators.required],
      date_naiss:[user.date_Naiss,Validators.required],
      sexe:[user.sexe,Validators.required],
      service:[user.service,Validators.required],
      adress:[user.adress,Validators.required],
      tel:[user.tel,Validators.required]

      })
    })

  }
  update(){
    this.adminservice.apdateUser(this.userformgroup.value).subscribe(data=>{
      alert("user mise a jour ");

    })

  }

}
