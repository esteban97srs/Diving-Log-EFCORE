import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DivingLogComponent } from './diving-log/diving-log.component';
import { SharedService} from './shared.service';
import { HttpClientModule} from '@angular/common/http';    
import { FormsModule,ReactiveFormsModule} from '@angular/forms';
import { CreateDivingLogComponent } from './create-diving-log/create-diving-log.component';    
import { RouterModule } from '@angular/router';
import { EditDivingLogComponent } from './edit-diving-log/edit-diving-log.component';
import { environment } from '../environments/environment';
import { ServiceWorkerModule } from '@angular/service-worker';


@NgModule({
  declarations: [
    AppComponent,
    DivingLogComponent,
    CreateDivingLogComponent,
    EditDivingLogComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    ServiceWorkerModule.register('../service-worker.js', { enabled: environment.production })
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }

