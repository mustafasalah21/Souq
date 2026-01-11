using MyRow = AdminP.Default.ReviewRow;

namespace AdminP.Default;

public interface IReviewSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class ReviewSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IReviewSaveHandler
{
}