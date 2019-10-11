import { Component, OnInit } from '@angular/core';
import { Grant } from '../Models/grant';
import { Grants } from '../Data/mock-grants';
import { Stat } from '../Models/stat';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  grants = Grants;
  stats: Stat;

  searchStatus = 'OPEN';
  constructor() { }
  ngOnInit() {
    this.stats = {
      totalAwardAmount: 432.00,
      totalExpenditures: 656645.92,
      totalRemainingBalance: 3322.11,
      percentageOfFundsSpent: 10,
      totalGrants: 2,
      totalFinancialReports: 2,
      totalProgrammingReports: 6
    };
  }
}
