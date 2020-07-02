import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AppSettings } from '../../models/header/appsettings';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})
export class UserService {

    constructor(private http: HttpClient) { }

    public getUserDetails(): Observable<any> {
      return this.http.get<any>(`https://localhost:44304/api/users`);
    }
   
    public get(): Observable<AppSettings> {
        return this.http.get<AppSettings>(`https://localhost:44304/api/configuration`);
    }

}
