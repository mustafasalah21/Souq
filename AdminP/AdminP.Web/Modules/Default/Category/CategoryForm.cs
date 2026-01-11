namespace AdminP.Modules.Default.Category;

[FormScript("Default.Category")]
[BasedOnRow(typeof(CategoryRow), CheckNames = true)]
public class CategoryForm
{
    public string Name { get; set; }
    public string Descrption { get; set; }
    public string Photo { get; set; }
}