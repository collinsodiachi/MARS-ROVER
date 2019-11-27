import { NasaImageService } from './Services/nasa-image.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatButtonModule} from '@angular/material/button';


import { AppComponent } from './app.component';
import { NasaImageComponent } from './nasa-image/nasa-image.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

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
    MatButtonModule
   

  ],
  providers: [
    NasaImageService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
