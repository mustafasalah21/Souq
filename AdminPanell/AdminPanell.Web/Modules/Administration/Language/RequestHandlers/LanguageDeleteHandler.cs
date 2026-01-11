using MyRow = AdminPanell.Administration.LanguageRow;

namespace AdminPanell.Administration;
public interface ILanguageDeleteHandler : IDeleteHandler<MyRow> { }

public class LanguageDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), ILanguageDeleteHandler
{
}