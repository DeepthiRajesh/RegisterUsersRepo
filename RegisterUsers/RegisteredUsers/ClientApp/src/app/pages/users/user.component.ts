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
    userTile: Array<UserTile> = new Array<UserTile>();

    constructor() {

        this.profileTileData = this.getProfileData();
    }

    ngOnInit() {
        this.userTile.push(this.getUserTileData(1, "Deepthi", "Rajesh", "Kuzhikkattil", "Author"));
        this.userTile.push(this.getUserTileData(2, "Muhammad", "Rahiz", "C", "Reviewer"));
        this.userTile.push(this.getUserTileData(3, "Keerthana", "L", "Nair", "Editor"));
    }

    getUserTileData(id: number, firstName: string, middleName: string, lastName: string, articleType: string): UserTile {
        return {
            id: id,
            firstName: firstName,
            middleName: middleName,
            lastName: lastName,
            author: "TES International (United States)",
            articleType: articleType,
            registrationDate: "28/04/2020",
            editingAssignments: 0,
            reviewAssignments: 0,
            submission: 1
        } as UserTile;
    }

    getProfileData():ProfileTile{
        return {
            place : "Troy, United States",
            mail : "automationuser081320@vialoopregistration.com",
            current : 0,
            completed : 1,
            endose : 0,
            reject : 1,
            review : 0,
            validation : 1,
            accept : 1,
            boardInvitation : 0,
            accepted : 1,
            rejected : 0,
            pending : 0,
            decline : 1,
            revoke : 0,
            remove : 0,
        } as ProfileTile;
    }
    profileViewDetails(user: any) {
        this.userTileData = Object.assign({}, user);
    }
}
