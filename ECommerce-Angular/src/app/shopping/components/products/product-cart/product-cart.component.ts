import { Component, OnInit, Input } from '@angular/core';
import { Product } from 'src/app/products/model/product';
import { ShoppingCartService } from 'src/app/shared/services/shopping-cart.service';
import { ProductService } from 'src/app/products/service/product.service';

@Component({
  selector: 'product-cart',
  templateUrl: './product-cart.component.html',
  styleUrls: ['./product-cart.component.css']
})
export class ProductCartComponent implements OnInit {
  productList: Product[];
 @Input('product') product: Product;
  constructor(private shoppingCartService: ShoppingCartService, private productService: ProductService) { }

  ngOnInit() {
    this.loadProductList();
  }

  addToCart(product){
  console.log(product);  
  }

  loadProductList(){
   return  this.productService.getProductList().subscribe(respon => {
      this.productList = respon;
    });
  }
}
