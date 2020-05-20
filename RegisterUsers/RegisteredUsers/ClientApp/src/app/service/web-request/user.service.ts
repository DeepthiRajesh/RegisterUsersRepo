import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import { RegistrationModel } from '../../models/common/registration.model';
import { Observable } from 'rxjs';
import { LoginModel } from '../../models/common/login.model';
import { AppSettings } from '../../models/header/appsettings';

@Injectable({
    providedIn: 'root'
})
export class UserService {

    constructor(private http: HttpService) { }

    public getUserDetails(userId: number): Observable<RegistrationModel> {
      return this.http.get<RegistrationModel>(`https://localhost:44304/api/users/${userId}`);
    }

    public registration(data: RegistrationModel): Observable<any> {
        return this.http.post<any>("https://localhost:44304/api/users/registration", data);
    }

    public login(data: LoginModel): Observable<any> {
        return this.http.post<any>("https://localhost:44304/api/users/login", data);
    }
    public get(): Observable<AppSettings> {
        return this.http.get<AppSettings>(`https://localhost:44304/api/configuration`);
    }
}
