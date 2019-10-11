import { Component, OnInit } from '@angular/core';
import { Grant } from '../Models/grant';
import { Grants } from '../Data/mock-grants';
import { Stat } from '../Models/stat';

@Component({
  selector: 'app-home-pending',
  templateUrl: './home-pending.component.html',
  styleUrls: ['./home-pending.component.css']
})
export class HomePendingComponent implements OnInit {
  grants = Grants;
  searchStatus = 'PENDING';
  stats: Stat;
  constructor() { }

  ngOnInit() {
    this.stats = {
      totalAwardAmount: 53463.00,
      totalExpenditures: 234.92,
      totalRemainingBalance: 433.11,
      percentageOfFundsSpent: 5,
      totalGrants: 3,
      totalFinancialReports: 22,
      totalProgrammingReports: 9
    };
  }

}
