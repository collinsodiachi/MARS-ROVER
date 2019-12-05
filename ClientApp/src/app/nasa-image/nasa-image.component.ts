import { NasaImageService } from './../Services/nasa-image.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'nasa-image',
  templateUrl: './nasa-image.component.html',
  styleUrls: ['./nasa-image.component.css']
})
export class NasaImageComponent implements OnInit {
  nasaImages: any[];
  nasaDates: any[];
  imageFound: boolean = false;
  searching: boolean = false;
  errorMessage;

  constructor(private  _nasaImageService: NasaImageService) { }

  getImages(date){
    if(this.nasaImages || this.errorMessage)
        this.nasaImages = this.errorMessage =null;
    this.searching = true;
    return this._nasaImageService.getImages(date).subscribe(
      data =>this.handleSuccess(data),
      error => this.errorMessage = error,
      () => this.searching = false
    )
  }
  getDates(){
    return this._nasaImageService.getAllDates().subscribe(
      data =>this.getDatesSuccess(data),
      error => this.errorMessage = error
    )
  }
  getDatesSuccess(data){
    this.nasaDates = data;
  }

  handleSuccess(data){
    if(data == null)
    {
      this.errorMessage = "No images found, Invalid date formate"
    }else{
      this.imageFound = true;
      this.nasaImages = data.photos;
    }
    
  }
  handleError(error){
    console.log(error);
  }
  ngOnInit() {
    this.getDates();
  }

}
