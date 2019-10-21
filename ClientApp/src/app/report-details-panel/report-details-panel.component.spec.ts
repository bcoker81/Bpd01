import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportDetailsPanelComponent } from './report-details-panel.component';

describe('ReportDetailsPanelComponent', () => {
  let component: ReportDetailsPanelComponent;
  let fixture: ComponentFixture<ReportDetailsPanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReportDetailsPanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportDetailsPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
