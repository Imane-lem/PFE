import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { FournisseurService } from 'src/app/Services/Fournisseur.service';

@Component({
  selector: 'app-addfour',
  templateUrl: './addfour.component.html',
  styleUrls: ['./addfour.component.css']
})
export class AddfourComponent implements OnInit {
  fourniformgroup!:FormGroup;

  constructor(private fb:FormBuilder,private fourniservice:FournisseurService,private router:Router) { }

  ngOnInit(): void {
    this.fourniformgroup=this.fb.group({
      
      name_f:["",Validators.required],
      adress_f:["",Validators.required],
      tel_f:["",Validators.required],
      fax_f:["",Validators.required],
      email_f:["",Validators.required],
      
    })
  }
  onsave(){
    this.fourniservice.AddFourni(this.fourniformgroup.value).subscribe(data=>{
      console.log(data);
      alert("fournisseur ajouter");
      this.router.navigateByUrl("/fournisseur");

    })
  }

}
