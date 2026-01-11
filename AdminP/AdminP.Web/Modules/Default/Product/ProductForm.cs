namespace AdminP.Modules.Default.Product;

[FormScript("Default.Product")]
[BasedOnRow(typeof(ProductRow), CheckNames = true)]
public class ProductForm
{
    public string Name { get; set; }
    public string Describtion { get; set; }
    public short Price { get; set; }
    public string Photo { get; set; }
    public string SuplierName { get; set; }
    public int CatId { get; set; }
    public DateOnly Date { get; set; }
    public string Url { get; set; }
}