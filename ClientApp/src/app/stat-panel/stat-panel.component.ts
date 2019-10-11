import { Component, OnInit } from '@angular/core';
import { Stat } from '../Models/stat';

@Component({
  selector: 'app-stat-panel',
  templateUrl: './stat-panel.component.html',
  styleUrls: ['./stat-panel.component.css']
})

export class StatPanelComponent implements OnInit {
  stat: Stat = {
    totalAwardAmount: 122348729.00,
    totalExpenditures: 2938472.92,
    totalRemainingBalance: 2389479.11,
    percentageOfFundsSpent: 50,
    totalGrants: 5,
    totalFinancialReports: 23,
    totalProgrammingReports: 19
  };

  constructor() { }

  ngOnInit() {
  }

}
