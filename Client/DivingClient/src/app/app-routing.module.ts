import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DivingLogComponent } from './diving-log/diving-log.component';
import { CreateDivingLogComponent } from './create-diving-log/create-diving-log.component';
import { EditDivingLogComponent } from './edit-diving-log/edit-diving-log.component';

const routes: Routes = [
  { path:'',component:DivingLogComponent},
  { path: 'DivingCreate', component: CreateDivingLogComponent},
  { path: 'DivingUpdate/:id', component: EditDivingLogComponent}
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
