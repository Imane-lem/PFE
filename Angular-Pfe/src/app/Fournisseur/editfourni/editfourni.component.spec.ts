import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditfourniComponent } from './editfourni.component';

describe('EditfourniComponent', () => {
  let component: EditfourniComponent;
  let fixture: ComponentFixture<EditfourniComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditfourniComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditfourniComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
