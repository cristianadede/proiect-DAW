import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { catchError, Observable, throwError } from 'rxjs';
import { Router } from '@angular/router';

@Injectable()
export class HttpErrorsInterceptor implements HttpInterceptor {

  constructor(private router: Router) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    console.log(request);
    return next.handle(request).pipe(catchError((error: HttpErrorResponse)=>{
      console.log(error.status, error.error.message);
      if (error.status === 500) {
        alert("eroare 500");
      }

      if (error.status === 401) {
        this.router.navigate(['/login']);
      }
      return throwError(error)
    }));
  }
}
