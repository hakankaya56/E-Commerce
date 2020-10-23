import { Component, OnInit } from '@angular/core';
import { ProductService } from '../service/product.service';
import { Product } from '../model/product';
import { Category } from '../model/category';


@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.css']
})

export class ProductsListComponent implements OnInit {
  products: Product[];
  categories: Category[];
  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.loadProducts();
  
  }

 loadProducts(){
   return this.productService.getProductList().subscribe(data => {
     this.products = data;
   })
 }

}
