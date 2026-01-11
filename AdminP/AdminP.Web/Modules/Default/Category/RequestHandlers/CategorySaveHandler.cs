using MyRow = AdminP.Modules.Default.Category.CategoryRow;

namespace AdminP.Modules.Default.Category.RequestHandlers;

public interface ICategorySaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class CategorySaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ICategorySaveHandler
{
}