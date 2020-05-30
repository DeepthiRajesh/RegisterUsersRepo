import { Component, OnInit } from '@angular/core';
import { UserService } from '../../../service/web-request/user.service';
import { HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
    selector: 'app-registration',
    templateUrl: './registration.component.html',
    styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
    validationMessage: string;
    public registration: any;

    constructor(private userService: UserService,
        private router: Router) {
        this.validationMessage = '';
       

    }

    ngOnInit() {

    }

    public isValidateCredential(): boolean {
        this.validationMessage = '';
        if (this.registration.password !== this.registration.confirmPassword) {
            this.validationMessage = 'Password should be same';
            return false;
        }
        return true;
    }

    //public submit(): void {
    //    if (!this.isValidateCredential()) {
    //        return;
    //    }
    //    this.userService.registration(this.registration).subscribe((
    //        response: HttpResponse<any>) => {
    //        if (response) {
    //            this.router.navigateByUrl('login');
    //            alert('Registration success');
    //        }
    //        else {
    //            alert('Registration Failed');
    //            (error: HttpErrorResponse) => {
    //                console.log(error);

    //            }
    //        }
    //    });
    //}
}

