using MyRow = AdminPanell.Administration.LanguageRow;

namespace AdminPanell.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow> { }

public class LanguageSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow>(context), ILanguageSaveHandler
{
}