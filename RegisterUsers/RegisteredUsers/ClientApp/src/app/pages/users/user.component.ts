import { Component, OnInit } from '@angular/core';
import { UserTile } from '../../models/user-models/user-tile';
import { ProfileTile } from '../../models/user-models/profile-tile';
import { UserService } from '../../service/web-request/user.service';

@Component({
    selector: 'app-user',
    templateUrl: './user.component.html',
    styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
    public userTileData = new UserTile();
    public profileTileData = new ProfileTile();
    userTile: UserTile[] = [];
    constructor() {

        this.userTileData.firstName = "Deepthi";
        this.userTileData.middleName = "Rajesh ";
        this.userTileData.lastName = "Kuzhikkattil";
        this.userTileData.author = "TES International (United States)"
        this.userTileData.articleType = "Author";;
        this.userTileData.registrationDate = "28/04/2020";
        this.userTileData.editingAssignments = 0;
        this.userTileData.reviewAssignments = 0;
        this.userTileData.submission = 1;

        this.profileTileData.userId = 1143191;
        this.profileTileData.place = "Troy, United States";
        this.profileTileData.mail = "automationuser081320@vialoopregistration.com";
        this.profileTileData.current = 0; 
        this.profileTileData.completed = 1;
        this.profileTileData.endose = 0;
        this.profileTileData.reject = 1;
        this.profileTileData.review = 0;
        this.profileTileData.validation = 1;
        this.profileTileData.accept = 1;
        this.profileTileData.boardInvitation = 0;
        this.profileTileData.accepted = 1;
        this.profileTileData.rejected = 0;
        this.profileTileData.pending = 0;
        this.profileTileData.decline = 1;
        this.profileTileData.revoke = 0;
        this.profileTileData.remove = 0;
    }

    ngOnInit() {
        this.userTile[0] = this.userTileData;
    }
   
}
