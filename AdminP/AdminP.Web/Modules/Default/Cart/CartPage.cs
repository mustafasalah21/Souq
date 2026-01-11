namespace AdminP.Modules.Default.Cart;

[PageAuthorize(typeof(CartRow))]
public class CartPage : Controller
{
    [Route("Default/Cart")]
    public ActionResult Index()
    {
        return this.GridPage<CartRow>("@/Default/Cart/CartPage");
    }
}