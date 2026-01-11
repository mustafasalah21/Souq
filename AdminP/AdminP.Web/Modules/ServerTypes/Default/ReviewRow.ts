import { fieldsProxy } from "@serenity-is/corelib";

export interface ReviewRow {
    Id?: number;
    Name?: string;
    Email?: string;
    Subject?: string;
    Description?: string;
}

export abstract class ReviewRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Default.Review';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ReviewRow>();
}