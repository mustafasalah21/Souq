using MyRow = AdminP.Modules.Default.Productimage.ProductimageRow;

namespace AdminP.Modules.Default.Productimage.RequestHandlers;

public interface IProductimageRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class ProductimageRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IProductimageRetrieveHandler
{
}