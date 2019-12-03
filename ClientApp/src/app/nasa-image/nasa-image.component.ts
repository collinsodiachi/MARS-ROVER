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
  constructor(private  _nasaImageService: NasaImageService) { }

  getImages(date){
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
      error => this.handleError(error),
    )
  }
  getDatesSuccess(data){
    this.nasaDates = data;
  }

  handleSuccess(data){
    this.imageFound = true;
    this.nasaImages = data.photos;
  }
  handleError(error){
    console.log(error);
  }
  ngOnInit() {
    this.getDates();
  }

}
