import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { FournisseurService } from 'src/app/Services/Fournisseur.service';

@Component({
  selector: 'app-editfourni',
  templateUrl: './editfourni.component.html',
  styleUrls: ['./editfourni.component.css']
})
export class EditfourniComponent implements OnInit {
  fourniformgroup!:FormGroup;
  idF:number;

  constructor(private fb:FormBuilder,
    private fourniservice:FournisseurService,
    private activateroot:ActivatedRoute,
    private roter:Router)
  { 
    this.idF=this.activateroot.snapshot.params['id_f'];
  }

  ngOnInit(): void {
    this.fourniservice.getFourniByid(this.idF).subscribe(fournisseur=>{
      console.log(fournisseur);
      this.fourniformgroup=this.fb.group({
        id_f:[fournisseur.id_f,Validators.required],
        name_f:[fournisseur.name_f,Validators.required],
        adress_f:[fournisseur.adress_f,Validators.required],
        tel_f:[fournisseur.tel_f,Validators.required],
        fax_f:[fournisseur.fax_f,Validators.required],
        email_f:[fournisseur.email_f,Validators.required],
      })
    })
   
  }

  UpdateF(){
    this.fourniservice.updateFournisseur(this.fourniformgroup.value).subscribe(data=>{
      alert("fourniseur a mise ajour");
      this.roter.navigateByUrl("/fournisseur");

    })

  }

}
