using MyRow = AdminPanell.Administration.RoleRow;

namespace AdminPanell.Administration;
public interface IRoleDeleteHandler : IDeleteHandler<MyRow> { }

public class RoleDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), IRoleDeleteHandler
{
}