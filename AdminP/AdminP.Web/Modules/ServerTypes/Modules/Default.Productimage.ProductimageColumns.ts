import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ProductimageRow } from "./Default.Productimage.ProductimageRow";

export interface ProductimageColumns {
    Id: Column<ProductimageRow>;
    ProductidName: Column<ProductimageRow>;
    Image: Column<ProductimageRow>;
}

export class ProductimageColumns extends ColumnsBase<ProductimageRow> {
    static readonly columnsKey = 'Default.Productimage';
    static readonly Fields = fieldsProxy<ProductimageColumns>();
}