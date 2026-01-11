using MyRow = AdminP.Modules.Default.Product.ProductRow;

namespace AdminP.Modules.Default.Product.RequestHandlers;

public interface IProductListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class ProductListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IProductListHandler
{
}