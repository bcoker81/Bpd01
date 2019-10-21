import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GrantAttachmentPanelComponent } from './grant-attachment-panel.component';

describe('GrantAttachmentPanelComponent', () => {
  let component: GrantAttachmentPanelComponent;
  let fixture: ComponentFixture<GrantAttachmentPanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GrantAttachmentPanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GrantAttachmentPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
