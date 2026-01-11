import { fieldsProxy } from "@serenity-is/corelib";

export interface ProductRow {
    Id?: number;
    Name?: string;
    Describtion?: string;
    Price?: number;
    Photo?: string;
    SuplierName?: string;
    CatId?: number;
    Date?: string;
    Url?: string;
    CatName?: string;
}

export abstract class ProductRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Default.Product';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProductRow>();
}