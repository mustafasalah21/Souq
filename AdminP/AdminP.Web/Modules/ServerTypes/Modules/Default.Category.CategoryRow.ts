import { fieldsProxy } from "@serenity-is/corelib";

export interface CategoryRow {
    Id?: number;
    Name?: string;
    Descrption?: string;
    Photo?: string;
}

export abstract class CategoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Default.Category';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<CategoryRow>();
}