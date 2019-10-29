import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeDeniedComponent } from './home-denied.component';

describe('HomeDeniedComponent', () => {
  let component: HomeDeniedComponent;
  let fixture: ComponentFixture<HomeDeniedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HomeDeniedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HomeDeniedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
