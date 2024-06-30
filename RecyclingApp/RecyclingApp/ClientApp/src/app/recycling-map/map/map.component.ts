import {Component, OnInit} from '@angular/core';
import {RecyclingLocationService} from "../../services/recycling-location.service";
import {RecyclingLocation} from "../../models/recycling-location";
import {MatDialog} from "@angular/material/dialog";
import {SuggestFormComponent} from "../suggest-form/suggest-form.component";
import {ControlPosition} from '@agm/core'
import {HelperService} from "../../services/helper.service";

@Component({
    selector: 'app-map',
    templateUrl: './map.component.html',
    styleUrls: ['./map.component.css']
})
export class MapComponent implements OnInit {
    public locations: RecyclingLocation[] = [];
    public boilerplateImageUrl: string = "https://material.angular.io/assets/img/examples/shiba2.jpg";

    public constructor(
        public dialog: MatDialog,
        private locationService: RecyclingLocationService,
        public helperService: HelperService) {
    }

    public ngOnInit() {
    }

    public openSuggestDialog() {
        const dialogRef = this.dialog.open(SuggestFormComponent, {
            height: `${this.helperService.displayHeight * 0.8}px`,
            width: `${this.helperService.displayWidth * 0.8}px`,
        });

        dialogRef.afterClosed().subscribe(result => {
            if (result.success) {
                this.locations.push(result.location);
            }
        })
    }

    public mapReady(map: any) {
        this.locationService.getAll().subscribe((data: RecyclingLocation[]) => {
            this.locations = data;
        });
        map.controls[ControlPosition.TOP_RIGHT].push(document.getElementById('SuggestPlace'));
    }
}