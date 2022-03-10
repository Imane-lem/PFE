import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  isAdmin: boolean = false;
  constructor() { }

  ngOnInit(): void {
    let data: any = localStorage.getItem("data");
    var result = JSON.parse(data);
    this.isAdmin = result.isAdmin;
  }

}
