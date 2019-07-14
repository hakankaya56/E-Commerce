import { Component, OnInit } from '@angular/core';
import { ProductService } from '../service/product.service';
import { Product } from '../model/product';

@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.css']
})
export class ProductsListComponent implements OnInit {
  products: Product[];
  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.productService.getProductList().subscribe( data => {
       this.products = data;
    })
  }

}
