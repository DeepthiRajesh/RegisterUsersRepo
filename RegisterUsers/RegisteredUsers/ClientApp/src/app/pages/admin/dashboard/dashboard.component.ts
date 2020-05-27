import { Component, OnInit } from '@angular/core';
import { UserService } from '../../../service/web-request/user.service';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

    public data: Array<any>;
    
    constructor(private userService: UserService) {
        this.data = new Array<any>();
       
    }

    ngOnInit() {
        this.getData();
    }

    public getData(): void {
        this.userService.getUserDetails()
            .subscribe(datas => {
                this.data.push(datas);
                console.log(this.data);
            }, error => console.error(error));
    }
}

