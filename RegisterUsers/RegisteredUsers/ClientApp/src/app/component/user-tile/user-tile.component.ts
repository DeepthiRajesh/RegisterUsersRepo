import { Component, OnInit, Input } from '@angular/core';
import { UserTile } from '../../models/user-models/user-tile';

@Component({
  selector: 'app-user-tile',
  templateUrl: './user-tile.component.html',
  styleUrls: ['./user-tile.component.css']
})
export class UserTileComponent implements OnInit {
    @Input() users: UserTile[];
    constructor() {
       
    }
   
    ngOnInit() {
       
  }

}
