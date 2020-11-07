import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';
import {DivingLogCreate} from './create-diving-log/DivingLog';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIurl = "https://localhost:5001/api/divings/"

  constructor(private http:HttpClient) { }

  GetAllDivingLog(): Observable<any[]>{
    return this.http.get<any>(this.APIurl);
  }
  CreateDivingLog(diving:DivingLogCreate): Observable<any> {
    return this.http.post(this.APIurl,diving);
  }
  UpdateDivingLog(val:any){
    return this.http.put(this.APIurl,val);
  }
  DeleteDivingLog(val:any){
    return this.http.delete(this.APIurl+val);
  }
}
