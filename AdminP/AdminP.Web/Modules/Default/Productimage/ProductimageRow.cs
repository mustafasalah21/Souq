using AdminP.Modules.Default.Product;

namespace AdminP.Modules.Default.Productimage;

[ConnectionKey("Default"), Module("Default"), TableName("productimage")]
[DisplayName("Productimage"), InstanceName("Productimage")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ProductimageRow : Row<ProductimageRow.RowFields>, IIdRow, INameRow
{
    const string jProductid = nameof(jProductid);

    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Productid"), Column("productid"), NotNull, ForeignKey(typeof(ProductRow)), LeftJoin(jProductid)]
    [TextualField(nameof(ProductidName)), ServiceLookupEditor(typeof(ProductRow))]
    public int? Productid { get => fields.Productid[this]; set => fields.Productid[this] = value; }

    [DisplayName("Image"), Column("image"), Size(500), QuickSearch, NameProperty]
    public string Image { get => fields.Image[this]; set => fields.Image[this] = value; }

    [DisplayName("Productid Name"), Origin(jProductid, nameof(ProductRow.Name))]
    public string ProductidName { get => fields.ProductidName[this]; set => fields.ProductidName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field Productid;
        public StringField Image;

        public StringField ProductidName;
    }
}