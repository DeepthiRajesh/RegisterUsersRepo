import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { DashboardComponent } from './pages/admin/dashboard/dashboard.component';
import { LoginComponent } from './pages/shared/login/login.component';
import { RegistrationComponent } from './pages/shared/registration/registration.component';
import { NavMenuComponent } from './pages/nav-menu/nav-menu.component';
import { HomeComponent } from './pages/user/home/home.component';
import { UserDashboardComponent } from './pages/user-dashboard/user-dashboard.component';



@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        RegistrationComponent,
        LoginComponent,
        DashboardComponent,
        UserDashboardComponent
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', component: HomeComponent, pathMatch: 'full' },
            { path: 'registration', component: RegistrationComponent },
            { path: 'login', component: LoginComponent },
            { path: 'dashboard', component: DashboardComponent },
            { path: 'userDashboard', component: UserDashboardComponent },
        ])
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
