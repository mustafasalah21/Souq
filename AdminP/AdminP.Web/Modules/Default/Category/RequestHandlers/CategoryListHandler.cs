using MyRow = AdminP.Modules.Default.Category.CategoryRow;

namespace AdminP.Modules.Default.Category.RequestHandlers;

public interface ICategoryListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class CategoryListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ICategoryListHandler
{
}