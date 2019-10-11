import { Component, OnInit, Input } from '@angular/core';
import { Stat } from '../Models/stat';

@Component({
  selector: 'app-stat-panel',
  templateUrl: './stat-panel.component.html',
  styleUrls: ['./stat-panel.component.css']
})

export class StatPanelComponent implements OnInit {
  @Input()
  stat: Stat;

  constructor() { }

  ngOnInit() {
  }

}
