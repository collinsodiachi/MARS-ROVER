import { Injectable } from '@angular/core';
import {environment} from '../../environments/environment';
import {HttpClient} from '@angular/common/http';
import 'rxjs/add/operator/map';

@Injectable({
  providedIn: 'root'
})
export class NasaImageService {
  private BASE_URL: string = 'https://localhost:5001/';
  private query: string;

  constructor(private _http: HttpClient) { }

  getImages(date){
    return this._http.get(this.BASE_URL + 'api/getallphoto/'+ date).map(res=>res);
  }
  getAllDates(){
    return this._http.get(this.BASE_URL + 'api/getalldate').map(res=>res);
  }
}