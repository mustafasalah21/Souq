import { initFormType, IntegerEditor, PrefixedContext, ServiceLookupEditor, StringEditor } from "@serenity-is/corelib";

export interface ProductForm {
    Name: StringEditor;
    Describtion: StringEditor;
    Price: IntegerEditor;
    Photo: StringEditor;
    SuplierName: StringEditor;
    CatId: ServiceLookupEditor;
    Date: StringEditor;
    Url: StringEditor;
}

export class ProductForm extends PrefixedContext {
    static readonly formKey = 'Default.Product';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductForm.init) {
            ProductForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = ServiceLookupEditor;

            initFormType(ProductForm, [
                'Name', w0,
                'Describtion', w0,
                'Price', w1,
                'Photo', w0,
                'SuplierName', w0,
                'CatId', w2,
                'Date', w0,
                'Url', w0
            ]);
        }
    }
}