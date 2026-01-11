namespace AdminP.Modules.Default.Category;

[PageAuthorize(typeof(CategoryRow))]
public class CategoryPage : Controller
{
    [Route("Default/Category")]
    public ActionResult Index()
    {
        return this.GridPage<CategoryRow>("@/Default/Category/CategoryPage");
    }
}