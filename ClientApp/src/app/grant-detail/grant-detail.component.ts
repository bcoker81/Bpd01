import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-grant-detail',
  templateUrl: './grant-detail.component.html',
  styleUrls: ['./grant-detail.component.css']
})
export class GrantDetailComponent implements OnInit {
  grantName: string;
  constructor() { }

  ngOnInit() {
    this.grantName = 'Adam Walsh Grant Details';
  }

}
