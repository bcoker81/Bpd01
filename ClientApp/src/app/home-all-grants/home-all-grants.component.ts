import { Component, OnInit, Inject } from '@angular/core';
import { Stat } from '../Models/stat';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home-all-grants',
  templateUrl: './home-all-grants.component.html',
  styleUrls: ['./home-all-grants.component.css']
})
export class HomeAllGrantsComponent implements OnInit {
  public grants: Grants[];
  searchStatus = 'ALL';
  stats: Stat;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Grants[]>(baseUrl + 'grants/status/2').subscribe(result => {
      this.grants = result;
    }, error => console.error(error));
  }
  ngOnInit() {
    this.stats = {
      totalAwardAmount: 5523.00,
      totalExpenditures: 988.26,
      totalRemainingBalance: 80.00,
      percentageOfFundsSpent: .44,
      totalGrants: 6,
      totalFinancialReports: 10,
      totalProgrammingReports: 30
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
