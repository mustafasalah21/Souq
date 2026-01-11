import { EntityGrid } from '@serenity-is/corelib';
import { ProductColumns, ProductRow, ProductService } from '../../ServerTypes/Default';
import { ProductDialog } from './ProductDialog';

export class ProductGrid extends EntityGrid<ProductRow> {
    static override [Symbol.typeInfo] = this.registerClass("AdminP.Default.");

    protected override getColumnsKey() { return ProductColumns.columnsKey; }
    protected override getDialogType() { return ProductDialog; }
    protected override getRowDefinition() { return ProductRow; }
    protected override getService() { return ProductService.baseUrl; }
}