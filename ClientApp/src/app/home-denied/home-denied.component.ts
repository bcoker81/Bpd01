import { Component, OnInit, Inject } from '@angular/core';
import { Stat } from '../Models/stat';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home-denied',
  templateUrl: './home-denied.component.html',
  styleUrls: ['./home-denied.component.css']
})
export class HomeDeniedComponent implements OnInit {
  public grants: Grants[];
  searchStatus = 'DENIED';
  stats: Stat;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Grants[]>(baseUrl + 'grants/status/4').subscribe(result => {
      this.grants = result;
    }, error => console.error(error));
  }

  ngOnInit() {
    this.stats = {
      totalAwardAmount: 2347.00,
      totalExpenditures: 2653.22,
      totalRemainingBalance: 111.00,
      percentageOfFundsSpent: .33,
      totalGrants: 2,
      totalFinancialReports: 12,
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
