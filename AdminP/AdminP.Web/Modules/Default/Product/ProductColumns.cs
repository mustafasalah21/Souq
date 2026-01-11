namespace AdminP.Modules.Default.Product;

[ColumnsScript("Default.Product")]
[BasedOnRow(typeof(ProductRow), CheckNames = true)]
public class ProductColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Describtion { get; set; }
    public short Price { get; set; }
    public string Photo { get; set; }
    public string SuplierName { get; set; }
    public string CatName { get; set; }
    public DateOnly Date { get; set; }
    public string Url { get; set; }
}