import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { ProductimageRow } from "./Default.Productimage.ProductimageRow";

export namespace ProductimageService {
    export const baseUrl = 'Default/Productimage';

    export declare function Create(request: SaveRequest<ProductimageRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProductimageRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProductimageRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProductimageRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProductimageRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProductimageRow>>;

    export const Methods = {
        Create: "Default/Productimage/Create",
        Update: "Default/Productimage/Update",
        Delete: "Default/Productimage/Delete",
        Retrieve: "Default/Productimage/Retrieve",
        List: "Default/Productimage/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>ProductimageService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}