import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditDivingLogComponent } from './edit-diving-log.component';

describe('EditDivingLogComponent', () => {
  let component: EditDivingLogComponent;
  let fixture: ComponentFixture<EditDivingLogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditDivingLogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditDivingLogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
