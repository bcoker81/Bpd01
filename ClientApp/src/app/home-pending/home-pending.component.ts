import { Component, OnInit, Inject } from '@angular/core';
import { Stat } from '../Models/stat';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home-pending',
  templateUrl: './home-pending.component.html',
  styleUrls: ['./home-pending.component.css']
})
export class HomePendingComponent implements OnInit {
  public grants: Grants[];
  searchStatus = 'PENDING';
  stats: Stat;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Grants[]>(baseUrl + 'grants/status/3').subscribe(result => {
      this.grants = result;
    }, error => console.error(error));
  }

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

interface Grants {
  id: number;
  grantNumber: number;
  grantName: string;
  status: number;
  division: string;
  projectStartDate: Date;
  projectEndDate: Date;
  financialReportDueDate: Date;
  programmingReportDueDate: Date;
  awardAmount: number;
  expenditures: number;
  remainingBalance: number;
  percentOfFundsSpent: number;
  match: number;
}
