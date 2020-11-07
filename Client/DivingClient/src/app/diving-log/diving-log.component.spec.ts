import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DivingLogComponent } from './diving-log.component';

describe('DivingLogComponent', () => {
  let component: DivingLogComponent;
  let fixture: ComponentFixture<DivingLogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DivingLogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DivingLogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
