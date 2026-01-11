using MyRow = AdminP.Default.ReviewRow;

namespace AdminP.Default;

public interface IReviewListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class ReviewListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IReviewListHandler
{
}