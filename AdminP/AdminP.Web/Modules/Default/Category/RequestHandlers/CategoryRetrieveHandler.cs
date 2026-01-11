using MyRow = AdminP.Modules.Default.Category.CategoryRow;

namespace AdminP.Modules.Default.Category.RequestHandlers;

public interface ICategoryRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class CategoryRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ICategoryRetrieveHandler
{
}