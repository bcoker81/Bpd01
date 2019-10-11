import { Component, OnInit } from '@angular/core';
import { Grant } from '../Models/grant';
import { Grants } from '../Data/mock-grants';
@Component({
  selector: 'app-grants-panel',
  templateUrl: './grants-panel.component.html',
  styleUrls: ['./grants-panel.component.css']
})
export class GrantsPanelComponent implements OnInit {
  grants = Grants;
  selectedGrant: Grant;
  constructor() { }

  ngOnInit() {
  }

  onSelect(grant: Grant): void {
    this.selectedGrant = grant;
  }

}
