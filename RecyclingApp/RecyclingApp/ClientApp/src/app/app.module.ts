import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import {RouterModule} from '@angular/router';

import {AppComponent} from './app.component';
import {MapComponent} from "./recycling-map/map/map.component";
import {SuggestFormComponent} from "./recycling-map/suggest-form/suggest-form.component";
import {RecyclingMapModule} from "./recycling-map/recycling-map.module";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
    declarations: [
        AppComponent,
    ],
    imports: [
        BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
            {path: 'locations', component: MapComponent},
            {path: 'add-location', component: SuggestFormComponent},
            {path: '', redirectTo: '/locations', pathMatch: 'full'},
        ]),
        RecyclingMapModule,
        BrowserAnimationsModule,
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule {
}