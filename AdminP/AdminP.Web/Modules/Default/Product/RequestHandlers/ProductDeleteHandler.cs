using MyRow = AdminP.Modules.Default.Product.ProductRow;

namespace AdminP.Modules.Default.Product.RequestHandlers;

public interface IProductDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class ProductDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IProductDeleteHandler
{
}