using MyRow = AdminPanell.Administration.LanguageRow;

namespace AdminPanell.Administration;
public interface ILanguageListHandler : IListHandler<MyRow> { }

public class LanguageListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), ILanguageListHandler
{
}