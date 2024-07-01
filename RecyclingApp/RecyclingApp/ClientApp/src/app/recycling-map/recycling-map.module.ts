import {NgModule} from '@angular/core';
import {CommonModule, NgOptimizedImage} from '@angular/common';
import {MapComponent} from './map/map.component';
import {SuggestFormComponent} from './suggest-form/suggest-form.component';
import {FormsModule} from "@angular/forms";
import {AgmCoreModule} from "@agm/core";
import {MatButtonModule} from "@angular/material/button";
import {MatDialogModule, MatDialogRef} from "@angular/material/dialog";
import {MatInputModule} from "@angular/material/input";
import {MatIconModule} from "@angular/material/icon";
import {MatCardModule} from "@angular/material/card";
import {MatGridListModule} from "@angular/material/grid-list";
import { LocationsListComponent } from './map/locations-list/locations-list.component';

@NgModule({
    declarations: [
        MapComponent,
        SuggestFormComponent,
        LocationsListComponent
    ],
    imports: [
        CommonModule,
        AgmCoreModule.forRoot({
            apiKey: 'AIzaSyBFXgith9BSepsZOZ5ZBF28hrYnCI15XF4'
        }),
        FormsModule,
        MatButtonModule,
        MatDialogModule,
        MatInputModule,
        MatIconModule,
        MatCardModule,
        NgOptimizedImage,
        MatGridListModule,
    ],
    providers: [
        {
            provide: MatDialogRef,
            useValue: {}
        },
    ]
})
export class RecyclingMapModule {
}