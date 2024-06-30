import {Component} from '@angular/core';
import {Router} from "@angular/router";
import {RecyclingLocationService} from "../../services/recycling-location.service";
import {RecyclingLocation} from "../../models/recycling-location";
import {MatDialogRef} from "@angular/material/dialog";

@Component({
    selector: 'app-suggest-form',
    templateUrl: './suggest-form.component.html',
    styleUrls: ['./suggest-form.component.css'],
})
export class SuggestFormComponent {
    public insertLocation: RecyclingLocation = {id: 0, name: '', latitude: 0, longitude: 0};
    public latitude: number = 49.5;
    public longitude: number = 31.1;

    public constructor(public dialogRef: MatDialogRef<SuggestFormComponent>, public locationService: RecyclingLocationService, private router: Router) {
    }

    public mapClicked(event: any): void {
        this.latitude = event.coords.lat;
        this.longitude = event.coords.lng;
        this.insertLocation.latitude = this.latitude;
        this.insertLocation.longitude = this.longitude;
    }

    public onSubmit(): void {
        this.locationService.create(this.insertLocation).subscribe((response) => {
            this.dialogRef.close({
                success: response,
                location: this.insertLocation
            });
        });
    }
}