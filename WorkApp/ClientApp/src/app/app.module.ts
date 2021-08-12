import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import {AdminModule} from './modules/admin/admin.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {StudentModule} from './modules/student/student.module';
import {ErrorComponent} from './components/error/error.component';
import {LoginComponent} from './login/login.component';
import {AuthModule} from './shared/modules/auth.module';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ErrorComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      //{ path: '', component: HomeComponent, pathMatch: 'full' },
      { path: '', component: LoginComponent, pathMatch: 'full' },
      { path: 'login', component: LoginComponent},
      { path: '**', component: ErrorComponent },
    ]),
    AdminModule,
    StudentModule,
    BrowserAnimationsModule,
    AuthModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
