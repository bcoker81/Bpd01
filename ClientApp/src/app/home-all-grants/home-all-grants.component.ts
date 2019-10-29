import { Component, OnInit, Inject } from '@angular/core';
import { Stat } from '../Models/stat';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home-all-grants',
  templateUrl: './home-all-grants.component.html',
  styleUrls: ['./home-all-grants.component.css']
})
export class HomeAllGrantsComponent implements OnInit {

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) { }

  ngOnInit() {
  }

}
