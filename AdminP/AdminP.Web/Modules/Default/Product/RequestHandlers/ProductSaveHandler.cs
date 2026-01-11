using MyRow = AdminP.Modules.Default.Product.ProductRow;

namespace AdminP.Modules.Default.Product.RequestHandlers;

public interface IProductSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class ProductSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IProductSaveHandler
{
}