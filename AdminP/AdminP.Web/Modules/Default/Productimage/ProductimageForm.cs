namespace AdminP.Modules.Default.Productimage;

[FormScript("Default.Productimage")]
[BasedOnRow(typeof(ProductimageRow), CheckNames = true)]
public class ProductimageForm
{
    public int Productid { get; set; }
    public string Image { get; set; }
}