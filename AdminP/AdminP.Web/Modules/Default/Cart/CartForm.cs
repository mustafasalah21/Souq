namespace AdminP.Modules.Default.Cart;

[FormScript("Default.Cart")]
[BasedOnRow(typeof(CartRow), CheckNames = true)]
public class CartForm
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}