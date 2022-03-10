import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AdministrationService } from 'src/app/Services/Administration.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent implements OnInit {
    userformgroup!:FormGroup;

  constructor( private adminservice:AdministrationService,private fb:FormBuilder) { }

  ngOnInit(): void {
    this.userformgroup=this.fb.group({
      login:["",Validators.required],
      password:["",Validators.required],
      name:["",Validators.required],
      prenom:["",Validators.required],
      date_naiss:["",Validators.required],
      sex:["",Validators.required],
      adress:["",Validators.required],
      service:["",Validators.required],
      tel:["",Validators.required]
    })
  }
  onSave(){
    this.adminservice.addUser(this.userformgroup.value).subscribe(data=>{
      alert("l'utilisateurs a ajouter");
    })

  }

}
