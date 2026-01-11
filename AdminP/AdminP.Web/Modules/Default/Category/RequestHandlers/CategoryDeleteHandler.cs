using MyRow = AdminP.Modules.Default.Category.CategoryRow;

namespace AdminP.Modules.Default.Category.RequestHandlers;

public interface ICategoryDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class CategoryDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ICategoryDeleteHandler
{
}