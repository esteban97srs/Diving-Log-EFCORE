import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { DivingLogCreate } from './DivingLog';
import {Validators, FormControl, FormGroup} from '@angular/forms';

@Component({
  selector: 'app-create-diving-log',
  templateUrl: './create-diving-log.component.html',
  styleUrls: ['./create-diving-log.component.css']
})
export class CreateDivingLogComponent implements OnInit {
  
  CreateForm =  new FormGroup({
    DateLog: new FormControl('', [Validators.required]),
    WindDirection: new FormControl('', [Validators.required, Validators.maxLength(15)]),
    WaveHeight: new FormControl('', [Validators.required]),
    SurfaceCurrent: new FormControl('', [Validators.required]),
    DiversNumber: new FormControl('', [Validators.required]),
    DivingPermit: new FormControl('', [Validators.required]),
    Observations: new FormControl('', [Validators.required,Validators.maxLength(35)])
  });
  
  constructor(private service:SharedService) {} // Implementando el servicio para enviar las peticiones a la api
  diving:DivingLogCreate = new DivingLogCreate();

  ngOnInit(){}

  CreateDivingLog(){
      this.diving.DiversNumber = this.diving.DiversNumber.toString();
      this.diving.WaveHeight = this.diving.WaveHeight.toString();
      this.diving.SurfaceCurrent = this.diving.SurfaceCurrent.toString();
      this.service.CreateDivingLog(this.diving).subscribe(data =>{
      alert("Guardado");

      this.diving.DateLog = "";
      this.diving.DiversNumber = "";
      this.diving.DivingPermit = "";
      this.diving.Observations = "";
      this.diving.SurfaceCurrent = "";
      this.diving.WaveHeight = "";
      this.diving.WindDirection = "";
    })
  }
}
