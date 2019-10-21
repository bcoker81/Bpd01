import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GrantDetailPanelComponent } from './grant-detail-panel.component';

describe('GrantDetailPanelComponent', () => {
  let component: GrantDetailPanelComponent;
  let fixture: ComponentFixture<GrantDetailPanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GrantDetailPanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GrantDetailPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
