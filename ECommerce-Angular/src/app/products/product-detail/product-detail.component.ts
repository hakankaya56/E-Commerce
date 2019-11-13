import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductService } from '../service/product.service';
import { Product } from '../model/product';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  constructor(private acvatedRoute: ActivatedRoute, private productService: ProductService) { }
   product: Product;
  ngOnInit() {
    this.acvatedRoute.params.subscribe(params => {this.getProductDetail(params.productId); });
  }


  getProductDetail(productId: number) {
     this.productService.getById(productId).subscribe(data => {this.product = data; });
  }
}
