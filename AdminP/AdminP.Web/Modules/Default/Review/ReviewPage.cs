namespace AdminP.Default.Pages;

[PageAuthorize(typeof(ReviewRow))]
public class ReviewPage : Controller
{
    [Route("Default/Review")]
    public ActionResult Index()
    {
        return this.GridPage<ReviewRow>("@/Default/Review/ReviewPage");
    }
}