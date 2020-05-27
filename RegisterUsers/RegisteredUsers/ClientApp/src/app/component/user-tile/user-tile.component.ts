import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { User } from '../../models/user-models/user';

@Component({
    selector: 'app-user-tile',
    templateUrl: './user-tile.component.html',
    styleUrls: ['./user-tile.component.css']
})
export class UserTileComponent implements OnInit {
    @Input() users: User[];
    @Output() userDetails: EventEmitter<any> = new EventEmitter<any>();
    constructor() { }

    ngOnInit() {

    }
    profileDetail(id: number) {
        var user = this.users.find(x => x.id === id);
        this.userDetails.emit(user);
    }
}
