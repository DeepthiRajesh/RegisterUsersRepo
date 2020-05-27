import { Component, OnInit, Input } from '@angular/core';
import { User } from '../../models/user-models/user';

@Component({
    selector: 'app-profile-tile',
    templateUrl: './profile-tile.component.html',
    styleUrls: ['./profile-tile.component.css']
})
export class ProfileTileComponent implements OnInit {
    @Input() userTile = new User();
    constructor() { }

    ngOnInit() {
    }
    
}
