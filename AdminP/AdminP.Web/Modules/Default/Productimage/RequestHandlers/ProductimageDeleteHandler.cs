using MyRow = AdminP.Modules.Default.Productimage.ProductimageRow;

namespace AdminP.Modules.Default.Productimage.RequestHandlers;

public interface IProductimageDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class ProductimageDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IProductimageDeleteHandler
{
}