import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {DivingLogCreate} from './create-diving-log/DivingLog';
import { DivingLogPut } from './edit-diving-log/DivingLogPut';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIurl = "https://localhost:5001/api/divings/"

  constructor(private http:HttpClient) { }

  GetAllDivingLog(): Observable<any[]>{
    return this.http.get<any>(this.APIurl);
  }
  GetDivingLogById(diving: DivingLogPut): Observable<any>{
    var direction = this.APIurl + diving;
    return this.http.get(direction);
  }
  CreateDivingLog(diving:DivingLogCreate): Observable<any> {
    return this.http.post(this.APIurl, diving);
  }
  UpdateDivingLog(diving:DivingLogPut) : Observable<any> {
    var id = diving.id;
    return this.http.put(this.APIurl+id,diving);
  }
  DeleteDivingLog(val:any){
    return this.http.delete(this.APIurl+val);
  }
}
