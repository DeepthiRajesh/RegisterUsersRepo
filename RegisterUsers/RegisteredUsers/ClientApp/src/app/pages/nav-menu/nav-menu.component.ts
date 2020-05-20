import { Component, OnInit } from '@angular/core';
import { UserService } from '../../service/web-request/user.service';
import { AppSettings } from '../../models/header/appsettings';

@Component({
    selector: 'app-nav-menu',
    templateUrl: './nav-menu.component.html',
    styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {

    public appSettings;
    constructor(private userService: UserService) {
        this.appSettings = new AppSettings();
    }

    ngOnInit() {
        this.getHeaderData();
    }

    isExpanded = false;

    collapse() {
        this.isExpanded = false;
    }

    toggle() {
        this.isExpanded = !this.isExpanded;
    }

    public getHeaderData() {
        this.userService.get()
            .subscribe(datas =>
                this.appSettings  = datas);
        console.log(this.appSettings);
    }
}
