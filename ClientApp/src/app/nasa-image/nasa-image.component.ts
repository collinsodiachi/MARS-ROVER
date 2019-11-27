import { NasaImageService } from './../Services/nasa-image.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'nasa-image',
  templateUrl: './nasa-image.component.html',
  styleUrls: ['./nasa-image.component.css']
})
export class NasaImageComponent implements OnInit {
  nasaImages: any[];
  imageFound: boolean = false;
  searching: boolean = false;
  constructor(private  _nasaImageService: NasaImageService) { }
  getImages(){
    this.searching = true;
    return this._nasaImageService.getImage().subscribe(
      data =>this.handleSuccess(data),
      error => this.handleError(error),
      () => this.searching = false
    )
  }

  handleSuccess(data){
    this.imageFound = true;
    this.nasaImages = data.photos;
  }

  handleError(error){
    console.log(error);
  }
  ngOnInit() {
  }

}
