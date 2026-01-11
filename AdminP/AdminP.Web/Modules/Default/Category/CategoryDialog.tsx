import { EntityDialog } from '@serenity-is/corelib';
import { CategoryForm, CategoryRow, CategoryService } from '../../ServerTypes/Default';

export class CategoryDialog extends EntityDialog<CategoryRow, any> {
    static override [Symbol.typeInfo] = this.registerClass("AdminP.Default.");

    protected override getFormKey() { return CategoryForm.formKey; }
    protected override getRowDefinition() { return CategoryRow; }
    protected override getService() { return CategoryService.baseUrl; }

    protected form = new CategoryForm(this.idPrefix);
}