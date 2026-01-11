import { EntityGrid } from '@serenity-is/corelib';
import { ProductimageColumns, ProductimageRow, ProductimageService } from '../../ServerTypes/Default';
import { ProductimageDialog } from './ProductimageDialog';

export class ProductimageGrid extends EntityGrid<ProductimageRow> {
    static override [Symbol.typeInfo] = this.registerClass("AdminP.Default.");

    protected override getColumnsKey() { return ProductimageColumns.columnsKey; }
    protected override getDialogType() { return ProductimageDialog; }
    protected override getRowDefinition() { return ProductimageRow; }
    protected override getService() { return ProductimageService.baseUrl; }
}