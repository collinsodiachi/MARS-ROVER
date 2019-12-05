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
      error => this.handleError(error),
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
    if(data == "Not Found")
    {
      this.errorMessage = "No Image Found"
    }else{
      this.imageFound = true;
      this.nasaImages = data.photos;
    }
    
  }
  handleError(error){
    if(error == "Bad Request")
      this.errorMessage = "Invalid Date Formate"
  }
  ngOnInit() {
    this.getDates();
  }

}
