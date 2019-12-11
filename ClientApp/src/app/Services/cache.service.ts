import { Observable } from 'rxjs/Observable';
import { HttpRequest,HttpResponse, HttpInterceptor, HttpHandler, HttpEvent, HttpResponseBase } from '@angular/common/http';
import { Injectable} from '@angular/core';


abstract class HttpCache{
    abstract get(req: HttpRequest<any>): HttpResponse<any> | null;
    abstract get(req: HttpRequest<any>, res: HttpResponse<any>): void;

}

@Injectable()
export class HttpCacheService implements HttpCache{
    private cache = {};


    put(req: HttpRequest<any>, res: HttpResponse<any>):void {
        this.cache[req.urlWithParams] = res;
    }

    get(req: HttpRequest<any>): HttpResponse<any> | null{
        return this.cache[req.urlWithParams];
    }
}