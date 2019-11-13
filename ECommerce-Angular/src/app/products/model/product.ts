import { Category } from './category';

export class Product {

    productID: number;
    productName: string;
    categoryID: number;
    quantityPerUnit: number;
    unitPrice: number;
    unitsInStock: number;
    categories: Category;
}
