import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeAllGrantsComponent } from './home-all-grants.component';

describe('HomeAllGrantsComponent', () => {
  let component: HomeAllGrantsComponent;
  let fixture: ComponentFixture<HomeAllGrantsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomeAllGrantsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeAllGrantsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
