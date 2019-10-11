import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AppService {
  _configuration = 'BASE_URL';
  constructor(private http: HttpClient) {

  }

  public getAll<T>(controller: string): Observable<T> {
    const url = (this._configuration + controller);
    // console.log('URL: ' + url);
    return this.http.get<T>(url);
  }

  public getSingle<T>(id: number, controllerName: string): Observable<T> {
    const url = (this._configuration + controllerName + id);
    // console.log('URL: ' + url);
    return this.http.get<T>(url);
  }

  public getByStatus<T>(search: number, controller: string): Observable<T> {
    const url = (this._configuration + controller + search);
    // console.log('URL: ' + url);
    return this.http.get<T>(url);
  }

  public getPicklist<T>(whichList: string): Observable<T> {
    return this.http.get<T>(this._configuration + 'grant/picklist/' + whichList);
  }
}

@Injectable()
export class CustomInterceptor implements HttpInterceptor {

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if (!req.headers.has('Content-Type')) {
      req = req.clone({ headers: req.headers.set('Content-Type', 'application/json') });
    }

    req = req.clone({ headers: req.headers.set('Accept', 'application/json') });
    console.log(JSON.stringify(req.headers));
    return next.handle(req);
  }
}
