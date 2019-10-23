import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeClosedComponent } from './home-closed.component';

describe('HomeClosedComponent', () => {
  let component: HomeClosedComponent;
  let fixture: ComponentFixture<HomeClosedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomeClosedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeClosedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
