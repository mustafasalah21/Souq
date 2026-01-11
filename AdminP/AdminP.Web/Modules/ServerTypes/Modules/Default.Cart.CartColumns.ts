import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CartRow } from "./Default.Cart.CartRow";

export interface CartColumns {
    Id: Column<CartRow>;
    UserId: Column<CartRow>;
    ProductName: Column<CartRow>;
    Quantity: Column<CartRow>;
}

export class CartColumns extends ColumnsBase<CartRow> {
    static readonly columnsKey = 'Default.Cart';
    static readonly Fields = fieldsProxy<CartColumns>();
}