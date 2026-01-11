using MyRow = AdminPanell.Administration.UserRow;

namespace AdminPanell.Administration;
public interface IUserRetrieveHandler : IRetrieveHandler<MyRow> { }

public class UserRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), IUserRetrieveHandler
{
}