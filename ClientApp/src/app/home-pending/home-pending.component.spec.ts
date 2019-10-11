import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HomePendingComponent } from './home-pending.component';

describe('HomePendingComponent', () => {
  let component: HomePendingComponent;
  let fixture: ComponentFixture<HomePendingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomePendingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomePendingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
