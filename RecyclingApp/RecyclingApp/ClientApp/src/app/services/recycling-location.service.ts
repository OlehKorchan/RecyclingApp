import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {RecyclingLocation} from "../models/recycling-location";
import {environment} from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class RecyclingLocationService {
  private readonly baseUrl: string = environment.baseUrl + "locations/";

  public constructor(private http: HttpClient) { }

  public getAll(): Observable<RecyclingLocation[]> {
    return this.http.get<RecyclingLocation[]>(this.baseUrl);
  }

  public create(item: RecyclingLocation): Observable<boolean> {
    return this.http.post<boolean>(this.baseUrl, item);
  }
}