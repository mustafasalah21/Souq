import { EntityDialog } from '@serenity-is/corelib';
import { ReviewForm, ReviewRow, ReviewService } from '../../ServerTypes/Default';

export class ReviewDialog extends EntityDialog<ReviewRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("AdminP.Default.");

    protected override getFormKey() { return ReviewForm.formKey; }
    protected override getRowDefinition() { return ReviewRow; }
    protected override getService() { return ReviewService.baseUrl; }

    protected form = new ReviewForm(this.idPrefix);
}