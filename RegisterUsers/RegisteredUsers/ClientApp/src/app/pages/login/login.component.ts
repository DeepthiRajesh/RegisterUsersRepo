import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../service/web-request/auth.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

    private email = '';
    private password = '';


    constructor(
        private router: Router, private auth: AuthService) {


    }

    ngOnInit() {
    }

    onSubmit() {
        this.auth.login(this.email, this.password).subscribe(data => {
            if (data) {
                this.router.navigate(['/user'])
                this.auth.setLoggedIn(true)
            } else {
                this.router.navigate(['/login'])
            }
        })
    }

    //function viewPassword() {
    //var passwordInput = document.getElementById("password");
    //var passStatus = document.getElementById('pass-status');

    //if (passwordInput.type == "password") {
    //    passwordInput.type = 'text';
    //    passStatus.className = 'fa fa-eye-slash';
    //}
    //else {
    //    passwordInput.type = 'password';
    //    passStatus.className = 'fa fa-eye';
    //} 
    //} 
}

