import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateDivingLogComponent } from './create-diving-log.component';

describe('CreateDivingLogComponent', () => {
  let component: CreateDivingLogComponent;
  let fixture: ComponentFixture<CreateDivingLogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateDivingLogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateDivingLogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
