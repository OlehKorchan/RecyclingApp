import { Component } from '@angular/core';
import {RecyclingLocation} from "../../../models/recycling-location";

@Component({
  selector: 'app-locations-list',
  templateUrl: './locations-list.component.html',
  styleUrls: ['./locations-list.component.css']
})
export class LocationsListComponent {
  public locations: RecyclingLocation[] = [];
  public boilerplateImageUrl: string = "https://material.angular.io/assets/img/examples/shiba2.jpg";
}