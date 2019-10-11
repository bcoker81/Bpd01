import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GrantsPanelComponent } from './grants-panel.component';

describe('GrantsPanelComponent', () => {
  let component: GrantsPanelComponent;
  let fixture: ComponentFixture<GrantsPanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GrantsPanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GrantsPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
