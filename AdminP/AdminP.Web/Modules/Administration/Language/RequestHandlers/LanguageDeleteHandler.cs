using MyRow = AdminP.Administration.LanguageRow;

namespace AdminP.Administration;
public interface ILanguageDeleteHandler : IDeleteHandler<MyRow> { }

public class LanguageDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), ILanguageDeleteHandler
{
}