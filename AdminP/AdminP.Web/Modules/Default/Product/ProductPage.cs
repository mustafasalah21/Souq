namespace AdminP.Modules.Default.Product;

[PageAuthorize(typeof(ProductRow))]
public class ProductPage : Controller
{
    [Route("Default/Product")]
    public ActionResult Index()
    {
        return this.GridPage<ProductRow>("@/Default/Product/ProductPage");
    }
}