namespace AdminP.Modules.Default.Cart;

[ColumnsScript("Default.Cart")]
[BasedOnRow(typeof(CartRow), CheckNames = true)]
public class CartColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public int UserId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
}