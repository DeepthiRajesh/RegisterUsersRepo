import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface myData {
    success: boolean,
    message: string
}
@Injectable({
    providedIn: 'root'
})
export class AuthService {

    public loggedInStatus = false

    constructor(private http: HttpClient) { }

    setLoggedIn(value: boolean) {
        this.loggedInStatus = value;
    }
    get isLoggedIn() {
        return this.loggedInStatus
    }
    login(email, password) {
        return this.http.post<myData>('https://localhost:44304/api/login',
            {
                email,
                password
            }
        );
    }
}
