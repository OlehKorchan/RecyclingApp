import {Component, HostListener} from '@angular/core';
import {HelperService} from "./services/helper.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';

  public constructor(private helperService: HelperService) {
    this.getScreenSize();
  }

  @HostListener('window:resize', ['$event'])
  getScreenSize(event?: any) {
    this.helperService.displayHeight = window.innerHeight;
    this.helperService.displayWidth = window.innerWidth;
  }
}