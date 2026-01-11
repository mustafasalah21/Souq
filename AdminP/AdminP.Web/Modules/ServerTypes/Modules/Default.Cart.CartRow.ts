import { fieldsProxy } from "@serenity-is/corelib";

export interface CartRow {
    Id?: number;
    UserId?: number;
    ProductId?: number;
    Quantity?: number;
    ProductName?: string;
}

export abstract class CartRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Default.Cart';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<CartRow>();
}