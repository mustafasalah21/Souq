namespace AdminP.Modules.Default.Productimage;

[ColumnsScript("Default.Productimage")]
[BasedOnRow(typeof(ProductimageRow), CheckNames = true)]
public class ProductimageColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ProductidName { get; set; }
    [EditLink]
    public string Image { get; set; }
}