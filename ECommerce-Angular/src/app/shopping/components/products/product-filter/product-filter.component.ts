import { Component, OnInit, Input } from '@angular/core';
import { CategoryService } from 'src/app/shared/services/category.service';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/products/model/category';

@Component({
  selector: 'product-filter',
  templateUrl: './product-filter.component.html',
  styleUrls: ['./product-filter.component.css']
})
export class ProductFilterComponent implements OnInit {
  categories: Category[];
  searchText;
  @Input('category') category;
  constructor(private categoryService: CategoryService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.loadCategories();
  }

  loadCategories(){
    return this.categoryService.getCategoryList().subscribe(data => {
      this.categories=data;
    });
   }


  //  applyFilter(value){
  //     this.categories.filter(c=>c.categoryName.includes(value));
  //  }
}
