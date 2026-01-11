using MyRow = AdminP.Administration.RoleRow;

namespace AdminP.Administration;
public interface IRoleListHandler : IListHandler<MyRow> { }

public class RoleListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), IRoleListHandler
{
}