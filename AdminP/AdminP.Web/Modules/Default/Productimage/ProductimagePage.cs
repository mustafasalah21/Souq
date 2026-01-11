namespace AdminP.Modules.Default.Productimage;

[PageAuthorize(typeof(ProductimageRow))]
public class ProductimagePage : Controller
{
    [Route("Default/Productimage")]
    public ActionResult Index()
    {
        return this.GridPage<ProductimageRow>("@/Default/Productimage/ProductimagePage");
    }
}