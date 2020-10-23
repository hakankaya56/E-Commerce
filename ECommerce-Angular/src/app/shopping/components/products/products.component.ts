import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/products/service/product.service';
import { Product } from 'src/app/products/model/product';
import { Category } from 'src/app/products/model/category';
import { CategoryService } from 'src/app/shared/services/category.service';
import { ActivatedRoute } from '@angular/router';
import { parse } from 'querystring';


@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];
  filteredProducts: Product[] = [];
  categories: Category[];
  category: string ;
  searchProduct
  constructor(private productService: ProductService, private categoryService: CategoryService, private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.loadProducts();
  }

  loadProducts(){
    return this.productService.getProductList().subscribe(data => {
      this.products = data;

      this.activatedRoute.queryParamMap.subscribe(params => {this.category = params.get('category'); 
      this.filteredProducts = (this.category) ?
      this.products.filter(p=>p.categoryID ==  parseInt(this.category)) 
      : this.products;
    })
    });
  }



  loadProductsByCategory(categoryId: number){
    return this.productService.getByCategory(categoryId).subscribe(data => {
      this.products = data;
    });
  }
}
