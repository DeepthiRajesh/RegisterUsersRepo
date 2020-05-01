import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import { RegistrationModel } from '../../models/common/registration.model';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class UserService {

    constructor(private http: HttpService) { }

    //public getUserDetails(userId: number): Observable<RegistrationModel> {
    //    return this.http.get<RegistrationModel>(`https://localhost:44304/api/v1/users/${userId}`);
    //}

    public registration(data: RegistrationModel): Observable<any> {
        return this.http.post<any>("https://localhost:44304/api/v1/users/registration", data);
    }
}
