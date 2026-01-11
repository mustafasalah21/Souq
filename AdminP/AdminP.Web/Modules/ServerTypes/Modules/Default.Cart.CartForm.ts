import { initFormType, IntegerEditor, PrefixedContext, ServiceLookupEditor } from "@serenity-is/corelib";

export interface CartForm {
    UserId: IntegerEditor;
    ProductId: ServiceLookupEditor;
    Quantity: IntegerEditor;
}

export class CartForm extends PrefixedContext {
    static readonly formKey = 'Default.Cart';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CartForm.init) {
            CartForm.init = true;

            var w0 = IntegerEditor;
            var w1 = ServiceLookupEditor;

            initFormType(CartForm, [
                'UserId', w0,
                'ProductId', w1,
                'Quantity', w0
            ]);
        }
    }
}