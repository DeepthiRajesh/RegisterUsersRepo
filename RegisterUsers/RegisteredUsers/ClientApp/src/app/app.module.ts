import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { DashboardComponent } from './pages/admin/dashboard/dashboard.component';
import { RegistrationComponent } from './pages/shared/registration/registration.component';
import { NavMenuComponent } from './pages/nav-menu/nav-menu.component';
import { UserComponent } from './pages/users/user.component';
import { UserTileComponent } from './component/user-tile/user-tile.component';
import { ProfileTileComponent } from './component/profile-tile/profile-tile.component';
import { LoginComponent } from './pages/login/login.component';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        RegistrationComponent,
        DashboardComponent,
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
            { path: 'registration', component: RegistrationComponent },
            { path: 'login', component: LoginComponent },
            { path: 'dashboard', component: DashboardComponent },
            { path: 'user', component: UserComponent },
            { path: 'user-tile', component: UserTileComponent },
            { path: 'profile-tile',component: ProfileTileComponent }
        ])
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
