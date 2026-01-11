import { EntityGrid } from '@serenity-is/corelib';
import { ReviewColumns, ReviewRow, ReviewService } from '../../ServerTypes/Default';
import { ReviewDialog } from './ReviewDialog';

export class ReviewGrid extends EntityGrid<ReviewRow> {
    static override [Symbol.typeInfo] = this.registerClass("AdminP.Default.");

    protected override getColumnsKey() { return ReviewColumns.columnsKey; }
    protected override getDialogType() { return ReviewDialog; }
    protected override getRowDefinition() { return ReviewRow; }
    protected override getService() { return ReviewService.baseUrl; }
}