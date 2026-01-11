import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ProductRow } from "./Default.Product.ProductRow";

export interface ProductColumns {
    Id: Column<ProductRow>;
    Name: Column<ProductRow>;
    Describtion: Column<ProductRow>;
    Price: Column<ProductRow>;
    Photo: Column<ProductRow>;
    SuplierName: Column<ProductRow>;
    CatName: Column<ProductRow>;
    Date: Column<ProductRow>;
    Url: Column<ProductRow>;
}

export class ProductColumns extends ColumnsBase<ProductRow> {
    static readonly columnsKey = 'Default.Product';
    static readonly Fields = fieldsProxy<ProductColumns>();
}