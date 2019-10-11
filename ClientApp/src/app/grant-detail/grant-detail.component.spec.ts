import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GrantDetailComponent } from './grant-detail.component';

describe('GrantDetailComponent', () => {
  let component: GrantDetailComponent;
  let fixture: ComponentFixture<GrantDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GrantDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GrantDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
