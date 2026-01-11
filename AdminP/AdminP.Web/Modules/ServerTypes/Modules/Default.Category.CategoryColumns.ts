import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CategoryRow } from "./Default.Category.CategoryRow";

export interface CategoryColumns {
    Id: Column<CategoryRow>;
    Name: Column<CategoryRow>;
    Descrption: Column<CategoryRow>;
    Photo: Column<CategoryRow>;
}

export class CategoryColumns extends ColumnsBase<CategoryRow> {
    static readonly columnsKey = 'Default.Category';
    static readonly Fields = fieldsProxy<CategoryColumns>();
}