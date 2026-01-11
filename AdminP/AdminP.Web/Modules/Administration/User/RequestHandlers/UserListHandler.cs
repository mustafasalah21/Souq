using MyRow = AdminP.Administration.UserRow;

namespace AdminP.Administration;
public interface IUserListHandler : IListHandler<MyRow, UserListRequest, ListResponse<MyRow>> { }

public class UserListHandler(IRequestContext context)
    : ListRequestHandler<MyRow, UserListRequest, ListResponse<MyRow>>(context), IUserListHandler
{
}