import { Routes } from '@angular/router';
import { ProductsListComponent } from './products/products-list/products-list.component';
import { LoginComponent } from './login/login/login.component';
import { RegisterComponent } from './register/register/register.component';
import { ProductDetailComponent } from './products/product-detail/product-detail.component';
import { ProductsCategoryComponent } from './products-category/products-category.component';
import { AdminOrdersComponent } from './admin/components/admin-orders/admin-orders.component';
import { AdminProductsComponent } from './admin/components/admin-products/admin-products.component';
import { ProductsComponent } from './shopping/components/products/products.component';
import { ShoppingCartComponent } from './shopping/components/shopping-cart/shopping-cart.component';
import { CheckOutComponent } from './shopping/components/check-out/check-out.component';
import { OrderSuccessComponent } from './shopping/components/order-success/order-success.component';
import { MyOrdersComponent } from './shopping/components/my-orders/my-orders.component';
import { ProductFormComponent } from './admin/components/product-form/product-form.component';

export const appRoutes: Routes = [
    {path: 'product-list', component: ProductsListComponent},
    {path: 'login', component: LoginComponent},
    {path: 'register', component: RegisterComponent},
    {path: 'product-detail/:productId', component: ProductDetailComponent},
    {path: 'category/:categoryId', component: ProductsCategoryComponent},
    {path: 'admin/products', component: AdminProductsComponent},
    {path: 'admin/orders', component: AdminOrdersComponent},
    {path: 'products', component: ProductsComponent},
    {path: 'shopping-cart', component:  ShoppingCartComponent},
    {path: 'check-out', component: CheckOutComponent},
    {path: 'order-succcess', component: OrderSuccessComponent},
    {path: 'my/orders', component: MyOrdersComponent},
    {path: 'admin/products/new', component: ProductFormComponent},
    {path: '***', redirectTo: 'product-list', pathMatch: 'full'}
];
