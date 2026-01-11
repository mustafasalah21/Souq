namespace AdminP.Modules.Default.Category;

[ColumnsScript("Default.Category")]
[BasedOnRow(typeof(CategoryRow), CheckNames = true)]
public class CategoryColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Descrption { get; set; }
    public string Photo { get; set; }
}