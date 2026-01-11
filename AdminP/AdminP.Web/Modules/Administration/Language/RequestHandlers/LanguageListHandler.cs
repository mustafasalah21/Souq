using MyRow = AdminP.Administration.LanguageRow;

namespace AdminP.Administration;
public interface ILanguageListHandler : IListHandler<MyRow> { }

public class LanguageListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), ILanguageListHandler
{
}