using MyRow = AdminP.Modules.Default.Product.ProductRow;

namespace AdminP.Modules.Default.Product.RequestHandlers;

public interface IProductRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class ProductRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IProductRetrieveHandler
{
}