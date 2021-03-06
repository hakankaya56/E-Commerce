import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../model/product';
import { environment } from 'src/environments/environment';
import { Category } from '../model/category';


@Injectable({
  providedIn: 'root'
})
export class ProductService {
  url = environment.baseUrl;
  constructor(private httpClient: HttpClient) { }


  getProductList(): Observable<Product[]> {
    return this.httpClient.get<Product[]>(this.url + 'Products/ProductList');
  }



  // tslint:disable-next-line: variable-name
  getByCategory(id: number): Observable<Product[]> {
    return this.httpClient.get<Product[]>(this.url + 'Products/GetByCategory?=' + id);

  }

  getById(productId: number): Observable<Product> {
    return this.httpClient.get<Product>(this.url + 'Products/detail?=' + productId);
  }
}
