import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';
import { DivingLogPut } from './DivingLogPut';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-diving-log',
  templateUrl: './edit-diving-log.component.html',
  styleUrls: ['./edit-diving-log.component.css']
})
export class EditDivingLogComponent implements OnInit {

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
    this.service.UpdateDivingLog(this.divingForm).subscribe(data => {
      console.log(data);
      window.location.reload();
    })
  } 
}

