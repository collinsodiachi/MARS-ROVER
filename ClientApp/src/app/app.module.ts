import { NasaImageService } from './Services/nasa-image.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NasaImageComponent } from './nasa-image/nasa-image.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    
    AppComponent,
    NasaImageComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule
  ],
  providers: [
    NasaImageService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
