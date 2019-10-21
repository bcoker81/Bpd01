import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GrantExpendituresComponent } from './grant-expenditures.component';

describe('GrantExpendituresComponent', () => {
  let component: GrantExpendituresComponent;
  let fixture: ComponentFixture<GrantExpendituresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GrantExpendituresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GrantExpendituresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
