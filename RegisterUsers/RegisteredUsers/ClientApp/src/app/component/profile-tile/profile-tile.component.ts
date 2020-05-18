import { Component, OnInit, Input } from '@angular/core';
import { ProfileTile } from '../../models/user-models/profile-tile';
import { UserTile } from '../../models/user-models/user-tile';

@Component({
  selector: 'app-profile-tile',
  templateUrl: './profile-tile.component.html',
  styleUrls: ['./profile-tile.component.css']
})
export class ProfileTileComponent implements OnInit {
    @Input() userTile = new UserTile();
    @Input() profileTile = new ProfileTile(); 
  constructor() { }

  ngOnInit() {
  }

}
