import { Component, OnInit } from '@angular/core';
import { User } from '../../models/user-models/user';
import { UserService } from '../../service/web-request/user.service';
import { Profile } from 'selenium-webdriver/firefox';

@Component({
    selector: 'app-user',
    templateUrl: './user.component.html',
    styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
    public userTileData = new User();
    userTile: Array<User> = new Array<User>();
    tileData: Profile;
    constructor(private userService : UserService) {

    }

    ngOnInit() {
       
       this.getUserData();
    }

    public getUserData(): any {
        this.userService.getUserDetails()
            .subscribe(datas => {               
                this.userTile = datas.map(x => Object.assign({}, x));
                this.userTileData = this.userTile.find(x => x.id == 1);
            }, error => console.error(error));
    }
    
    profileViewDetails(user: any) {
        this.userTileData = Object.assign({}, user); 
    }
}
