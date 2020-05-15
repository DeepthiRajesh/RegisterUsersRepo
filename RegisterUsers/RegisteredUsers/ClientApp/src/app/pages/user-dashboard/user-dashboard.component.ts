import { Component, OnInit } from '@angular/core';
import { UserTile } from '../../models/user/user-tile';
import { ProfileTile } from '../../models/user/profile-tile';

@Component({
  selector: 'app-user-dashboard',
  templateUrl: './user-dashboard.component.html',
  styleUrls: ['./user-dashboard.component.css']
})
export class UserDashboardComponent implements OnInit {
    public userTileData = new UserTile();
    public profileTileData = new ProfileTile();
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

  }

}
