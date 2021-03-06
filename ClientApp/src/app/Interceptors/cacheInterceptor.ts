import { Observable } from 'rxjs/Observable';
import { HttpCacheService } from '../Services/cache.service';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpResponse } from '@angular/common/http';
import { Injectable } from "@angular/core";
import 'rxjs/add/operator/do';
import 'rxjs/add/observable/of';




@Injectable()
export class CacheInterceptor implements HttpInterceptor{
    constructor(private _cacheService: HttpCacheService){}

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>>{
        
        const cachedResponse = this._cacheService[req.urlWithParams]|| null;
        
        if(cachedResponse){
            console.log("Response from Cache");
            return Observable.of(cachedResponse);
        }

        return next.handle(req).do(event => {
            if(event instanceof HttpResponse){
                this._cacheService[req.urlWithParams] = event;
                console.log("Response from Server");
            }
        })
    }
}