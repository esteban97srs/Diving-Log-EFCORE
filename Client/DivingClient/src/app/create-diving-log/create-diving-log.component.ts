import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import {DivingLogCreate} from './DivingLog';


@Component({
  selector: 'app-create-diving-log',
  templateUrl: './create-diving-log.component.html',
  styleUrls: ['./create-diving-log.component.css']
})
export class CreateDivingLogComponent implements OnInit {
  
  constructor(private service:SharedService) {} // Implementando el servicio para enviar las peticiones a la api
  
  diving:DivingLogCreate = new DivingLogCreate();

  ngOnInit(): void {
    
  }

  CreateDivingLog(){
    this.diving.DiversNumber = this.diving.DiversNumber.toString();
    this.diving.WaveHeight = this.diving.WaveHeight.toString();
    this.service.CreateDivingLog(this.diving).subscribe(data =>{
      console.log(data)
      window.location.reload();
     })
    };
}
