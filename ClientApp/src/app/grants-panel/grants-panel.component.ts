import { Component, OnInit, Input } from '@angular/core';
import { Grant } from '../Models/grant';

@Component({
  selector: 'app-grants-panel',
  templateUrl: './grants-panel.component.html',
  styleUrls: ['./grants-panel.component.css']
})
export class GrantsPanelComponent implements OnInit {
  @Input()
  grants: Grant[];
  selectedGrant: Grant;
  constructor() { }

  ngOnInit() {
  }

  onSelect(grant: Grant): void {
    this.selectedGrant = grant;
  }

}
