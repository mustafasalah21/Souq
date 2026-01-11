import { EntityGrid } from '@serenity-is/corelib';
import { CategoryColumns, CategoryRow, CategoryService } from '../../ServerTypes/Default';
import { CategoryDialog } from './CategoryDialog';

export class CategoryGrid extends EntityGrid<CategoryRow> {
    static override [Symbol.typeInfo] = this.registerClass("AdminP.Default.");

    protected override getColumnsKey() { return CategoryColumns.columnsKey; }
    protected override getDialogType() { return CategoryDialog; }
    protected override getRowDefinition() { return CategoryRow; }
    protected override getService() { return CategoryService.baseUrl; }
}