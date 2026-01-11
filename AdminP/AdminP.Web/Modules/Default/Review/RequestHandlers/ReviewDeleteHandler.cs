using MyRow = AdminP.Default.ReviewRow;

namespace AdminP.Default;

public interface IReviewDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class ReviewDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IReviewDeleteHandler
{
}