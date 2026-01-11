import { EntityDialog } from '@serenity-is/corelib';
import { ProductForm, ProductRow, ProductService } from '../../ServerTypes/Default';

export class ProductDialog extends EntityDialog<ProductRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("AdminP.Default.");

    protected override getFormKey() { return ProductForm.formKey; }
    protected override getRowDefinition() { return ProductRow; }
    protected override getService() { return ProductService.baseUrl; }

    protected form = new ProductForm(this.idPrefix);
}