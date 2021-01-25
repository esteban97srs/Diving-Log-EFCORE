import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';
import { DivingLogPut } from './DivingLogPut';
import { ActivatedRoute } from '@angular/router';
import {Validators, FormControl, FormGroup} from '@angular/forms';

@Component({
  selector: 'app-edit-diving-log',
  templateUrl: './edit-diving-log.component.html',
  styleUrls: ['./edit-diving-log.component.css']
})
export class EditDivingLogComponent implements OnInit {
 
    EditForm = new FormGroup({
    DateLog: new FormControl('', [Validators.required]),
    WindDirection: new FormControl('', [Validators.required,Validators.maxLength(15)]),
    WaveHeight: new FormControl('', [Validators.required]),
    SurfaceCurrent: new FormControl('', [Validators.required]),
    DiversNumber: new FormControl('', [Validators.required]),
    DivingPermit: new FormControl('', [Validators.required]),
    Observations: new FormControl('', [Validators.required,Validators.maxLength(35)])
  });

  constructor(private service: SharedService, private rutaActiva: ActivatedRoute) { }
  divingForm:DivingLogPut = new DivingLogPut();

  ngOnInit() {
    var id = this.rutaActiva.snapshot.params.id;
    this.service.GetDivingLogById(id).subscribe(data => {
      this.divingForm = data;
    });       
  }
  UpdateDivingLog() {
    this.divingForm.diversNumber = this.divingForm.diversNumber.toString();
    this.divingForm.waveHeight = this.divingForm.waveHeight.toString();
    this.divingForm.surfaceCurrent = this.divingForm.surfaceCurrent.toString();
    this.service.UpdateDivingLog(this.divingForm).subscribe(data => {
     alert("Actualizado");      
    })
  } 
}

