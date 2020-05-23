import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { UserTile } from '../../models/user-models/user-tile';

@Component({
    selector: 'app-user-tile',
    templateUrl: './user-tile.component.html',
    styleUrls: ['./user-tile.component.css']
})
export class UserTileComponent implements OnInit {
    @Input() users: UserTile[];
    @Output() userDetails: EventEmitter<any> = new EventEmitter<any>();
    constructor() {

    }

    ngOnInit() {

    }
    profileDetail(id: number) {
        var user = this.users.find(x => x.id === id);
        this.userDetails.emit(user);
    }
}
