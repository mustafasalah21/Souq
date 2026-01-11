using MyRow = AdminP.Default.ReviewRow;

namespace AdminP.Default;

public interface IReviewRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class ReviewRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IReviewRetrieveHandler
{
}