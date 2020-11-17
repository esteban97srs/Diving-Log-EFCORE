import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import { DivingLogCreate } from '../create-diving-log/DivingLog';

@Component({
  selector: 'app-diving-log',
  templateUrl: './diving-log.component.html',
  styleUrls: ['./diving-log.component.css']
})
export class DivingLogComponent implements OnInit {

  constructor(private service:SharedService) { }
  DivingList:any=[];
  diving:DivingLogCreate = new DivingLogCreate();

  ngOnInit(): void {
    this.refreshDivingList();
  }

  DeleteDivingLog(item){
    if(confirm("Seguro quieres eliminar el registro : "+item.id+"?")){
      var val = item.id;
      this.service.DeleteDivingLog(val).subscribe(data => {
        alert(data.toString());
      })
      window.location.reload();
    }
  }


  refreshDivingList(){
    this.service.GetAllDivingLog().subscribe(data => {
        this.DivingList = data; 
    });
  }
}
