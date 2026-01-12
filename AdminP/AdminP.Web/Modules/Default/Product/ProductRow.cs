using AdminP.Modules.Default.Category;

namespace AdminP.Modules.Default.Product;

[ConnectionKey("Default"), Module("Default"), TableName("product")]
[DisplayName("Product"), InstanceName("Product")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
{
    const string jCat = nameof(jCat);

    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(45), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Describtion"), Size(450)]
    public string Describtion { get => fields.Describtion[this]; set => fields.Describtion[this] = value; }

    [DisplayName("Price")]
    public short? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("Photo"), ImageUploadEditor, Size(45)]
    public string Photo { get => fields.Photo[this]; set => fields.Photo[this] = value; }

    [DisplayName("Suplier Name"), Size(45)]
    public string SuplierName { get => fields.SuplierName[this]; set => fields.SuplierName[this] = value; }

    [DisplayName("Cat"), ForeignKey(typeof(CategoryRow)), LeftJoin(jCat), TextualField(nameof(CatName))]
    [ServiceLookupEditor(typeof(CategoryRow), Service = "Default/Category/List")]
    public int? CatId { get => fields.CatId[this]; set => fields.CatId[this] = value; }

    [DisplayName("Date")]
    public DateTime? Date
    {
        get => fields.Date[this];
        set => fields.Date[this] = value;
    }


    [DisplayName("Url"), Size(500)]
    public string Url { get => fields.Url[this]; set => fields.Url[this] = value; }

    [DisplayName("Cat Name"), Origin(jCat, nameof(CategoryRow.Name))]
    public string CatName { get => fields.CatName[this]; set => fields.CatName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Describtion;
        public Int16Field Price;
        public StringField Photo;
        public StringField SuplierName;
        public Int32Field CatId;
        public DateTimeField Date;
        public StringField Url;

        public StringField CatName;
    }
}