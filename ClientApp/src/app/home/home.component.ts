import { Component, Inject, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Stat } from '../Models/stat';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public grants: Grants[];
  stats: Stat;

  searchStatus = 'OPEN';
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Grants[]>(baseUrl + 'grants/status').subscribe(result => {
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
  status: string;
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
