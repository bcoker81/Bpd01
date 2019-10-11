import { Component, OnInit } from '@angular/core';
import { Grant } from '../Models/grant';
import { Grants } from '../Data/mock-grants';
@Component({
  selector: 'app-home-pending',
  templateUrl: './home-pending.component.html',
  styleUrls: ['./home-pending.component.css']
})
export class HomePendingComponent implements OnInit {
  grants = Grants;
  constructor() { }

  ngOnInit() {
  }

}
