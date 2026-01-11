using MyRow = AdminP.Administration.UserRow;

namespace AdminP.Administration;
public interface IUserRetrieveHandler : IRetrieveHandler<MyRow> { }

public class UserRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), IUserRetrieveHandler
{
}