import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from 'src/app/products/model/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  baseUrl = environment.baseUrl + 'Categories/';
  constructor(private httpClient: HttpClient) { }


  getCategoryList(): Observable<Category[]> {
    return this.httpClient.get<Category[]>(this.baseUrl + 'GetCategoryList');
  }
}
