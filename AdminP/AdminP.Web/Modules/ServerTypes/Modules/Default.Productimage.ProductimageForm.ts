import { initFormType, PrefixedContext, ServiceLookupEditor, StringEditor } from "@serenity-is/corelib";

export interface ProductimageForm {
    Productid: ServiceLookupEditor;
    Image: StringEditor;
}

export class ProductimageForm extends PrefixedContext {
    static readonly formKey = 'Default.Productimage';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductimageForm.init) {
            ProductimageForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;

            initFormType(ProductimageForm, [
                'Productid', w0,
                'Image', w1
            ]);
        }
    }
}