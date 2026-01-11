using MyRow = AdminPanell.Administration.RoleRow;

namespace AdminPanell.Administration;
public interface IRoleListHandler : IListHandler<MyRow> { }

public class RoleListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), IRoleListHandler
{
}