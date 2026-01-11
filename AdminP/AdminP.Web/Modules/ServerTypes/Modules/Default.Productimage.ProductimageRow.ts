import { fieldsProxy } from "@serenity-is/corelib";

export interface ProductimageRow {
    Id?: number;
    Productid?: number;
    Image?: string;
    ProductidName?: string;
}

export abstract class ProductimageRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Image';
    static readonly localTextPrefix = 'Default.Productimage';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProductimageRow>();
}