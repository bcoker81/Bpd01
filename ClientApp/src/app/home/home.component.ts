import { Component, OnInit } from '@angular/core';
import { Grant } from '../Models/grant';
import { Grants } from '../Data/mock-grants';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  grants = Grants;

  constructor() { }
  ngOnInit() {

  }
}
