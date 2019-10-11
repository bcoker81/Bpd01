import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { SideBarComponent } from './side-bar/side-bar.component';
import { HeaderComponent } from './header/header.component';
import { AddGrantComponent } from './add-grant/add-grant.component';
import { StatPanelComponent } from './stat-panel/stat-panel.component';
import { StatusBarComponent } from './status-bar/status-bar.component';
import { GrantsPanelComponent } from './grants-panel/grants-panel.component';
import { SpinnerLoaderComponent } from './spinner-loader/spinner-loader.component';
import { GrantDetailComponent } from './grant-detail/grant-detail.component';
import { HomePendingComponent } from './home-pending/home-pending.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    SideBarComponent,
    HeaderComponent,
    AddGrantComponent,
    StatPanelComponent,
    StatusBarComponent,
    GrantsPanelComponent,
    SpinnerLoaderComponent,
    GrantDetailComponent,
    HomePendingComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'add-grant', component: AddGrantComponent },
      { path: 'pending-grant', component: HomePendingComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
