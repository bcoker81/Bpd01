import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GanInfoPanelComponent } from './gan-info-panel.component';

describe('GanInfoPanelComponent', () => {
  let component: GanInfoPanelComponent;
  let fixture: ComponentFixture<GanInfoPanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GanInfoPanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GanInfoPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
