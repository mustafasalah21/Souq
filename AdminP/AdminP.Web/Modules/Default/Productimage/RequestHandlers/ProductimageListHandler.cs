using MyRow = AdminP.Modules.Default.Productimage.ProductimageRow;

namespace AdminP.Modules.Default.Productimage.RequestHandlers;

public interface IProductimageListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class ProductimageListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IProductimageListHandler
{
}