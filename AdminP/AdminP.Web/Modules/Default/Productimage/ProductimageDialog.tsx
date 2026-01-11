import { EntityDialog } from '@serenity-is/corelib';
import { ProductimageForm, ProductimageRow, ProductimageService } from '../../ServerTypes/Default';

export class ProductimageDialog extends EntityDialog<ProductimageRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("AdminP.Default.");

    protected override getFormKey() { return ProductimageForm.formKey; }
    protected override getRowDefinition() { return ProductimageRow; }
    protected override getService() { return ProductimageService.baseUrl; }

    protected form = new ProductimageForm(this.idPrefix);
}