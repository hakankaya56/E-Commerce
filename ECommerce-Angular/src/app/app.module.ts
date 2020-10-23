import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap'
import { MatInputModule } from '@angular/material/input';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav/nav.component';
import { ProductsListComponent } from './products/products-list/products-list.component';
import { LoginComponent } from './login/login/login.component';
import { RegisterComponent } from './register/register/register.component';
import { RouterModule } from '@angular/router';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { appRoutes } from './routes';

import { ProductDetailComponent } from './products/product-detail/product-detail.component';
import { ProductFormComponent } from './admin/components/product-form/product-form.component';
import { AdminProductsComponent } from './admin/components/admin-products/admin-products.component';
import {AdminOrdersComponent} from './admin/components/admin-orders/admin-orders.component';
import {ProductsComponent} from './shopping/components/products/products.component';
import { ShoppingCartComponent } from './shopping/components/shopping-cart/shopping-cart.component';
import { CheckOutComponent } from './shopping/components/check-out/check-out.component';
import { OrderSuccessComponent } from './shopping/components/order-success/order-success.component';
import { MyOrdersComponent } from './shopping/components/my-orders/my-orders.component';
import { ProductFilterComponent } from './shopping/components/products/product-filter/product-filter.component';
import { ProductCartComponent } from './shopping/components/products/product-cart/product-cart.component';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      ProductsListComponent,
      LoginComponent,
      RegisterComponent,
      ProductDetailComponent,
      ProductFormComponent,
      AdminProductsComponent,
      AdminOrdersComponent,
      ProductsComponent,
      ShoppingCartComponent,
      CheckOutComponent,
      OrderSuccessComponent,
      MyOrdersComponent,
      ProductFilterComponent,
      ProductCartComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      NgbModule,
      MatInputModule,
      BrowserAnimationsModule,
      FormsModule,
      ReactiveFormsModule,
      Ng2SearchPipeModule,
      RouterModule.forRoot(appRoutes)
   ],
   providers: [],
   bootstrap: [
      AppComponent,

   ]
})
export class AppModule { }
