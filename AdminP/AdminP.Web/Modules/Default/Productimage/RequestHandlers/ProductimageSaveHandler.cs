using MyRow = AdminP.Modules.Default.Productimage.ProductimageRow;

namespace AdminP.Modules.Default.Productimage.RequestHandlers;

public interface IProductimageSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class ProductimageSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IProductimageSaveHandler
{
}