import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import { Observable } from 'rxjs';
import { AppSettings } from '../../models/header/appsettings';

@Injectable({
    providedIn: 'root'
})
export class UserService {

    constructor(private http: HttpService) { }

    public getUserDetails(): Observable<any> {
      return this.http.get<any>(`https://localhost:44304/api/users`);
    }

    public registration(data: any): Observable<any> {
        return this.http.post<any>("https://localhost:44304/api/users/registration", data);
    }

    public login(data: any): Observable<any> {
        return this.http.post<any>("https://localhost:44304/api/users/login", data);
    }
    public get(): Observable<AppSettings> {
        return this.http.get<AppSettings>(`https://localhost:44304/api/configuration`);
    }
}
