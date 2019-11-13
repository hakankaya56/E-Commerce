import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/shared/services/category.service';
import { Category } from 'src/app/products/model/category';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {

  categoryList: Category[];
  constructor(private categoryService: CategoryService) { }

  ngOnInit() {

    this.loadCategoryList();
  }
 loadCategoryList() {
   return this.categoryService.getCategoryList().subscribe(respon => {
     this.categoryList = respon;
   });
 }
}
