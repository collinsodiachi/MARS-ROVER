import { catchError } from 'rxjs/operators';
import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppInterceptorService implements HttpInterceptor{

  constructor() { }

  handleError(error: HttpErrorResponse){
    return throwError(error.statusText || "Server Error");
  }

  intercept(req: HttpRequest<any>, next: HttpHandler): 
  Observable<HttpEvent<any>>{
    return next.handle(req)
    .pipe(
      catchError(this.handleError)
    );
  }

}

