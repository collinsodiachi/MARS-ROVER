import { NasaImageService } from './Services/nasa-image.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatButtonModule} from '@angular/material/button';


import { AppComponent } from './app.component';
import { NasaImageComponent } from './nasa-image/nasa-image.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppInterceptorService } from './Services/app-interceptor.service';

@NgModule({
  declarations: [
    
    AppComponent,
    NasaImageComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatProgressBarModule,
    MatButtonModule,
    AppRoutingModule
   

  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AppInterceptorService,
      multi: true
    },
    NasaImageService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
