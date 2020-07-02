import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './pages/nav-menu/nav-menu.component';
import { UserComponent } from './pages/users/user.component';
import { UserTileComponent } from './component/user-tile/user-tile.component';
import { ProfileTileComponent } from './component/profile-tile/profile-tile.component';
import { LoginComponent } from './pages/login/login.component';
import { AuthGuard } from './guard/auth.guard';
import { AuthService } from './service/web-request/auth.service';



@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,      
        UserComponent,
        UserTileComponent,
        ProfileTileComponent,
        LoginComponent
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', component: LoginComponent, pathMatch: 'full' },
            { path: 'login', component: LoginComponent },
            { path: 'user', component: UserComponent,canActivate:[AuthGuard] },
            { path: 'user-tile', component: UserTileComponent },
            { path: 'profile-tile',component: ProfileTileComponent }
        ])
    ],
    providers: [AuthService,AuthGuard],
    bootstrap: [AppComponent]
})
export class AppModule { }
