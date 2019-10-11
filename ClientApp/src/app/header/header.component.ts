import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  userId: string;
  division: string;
  constructor() { }

  ngOnInit() {
    this.userId = 'cokerb';
    this.division = 'cjis';
  }

}
