namespace AdminP.Modules.Default.Category;

[ConnectionKey("Default"), Module("Default"), TableName("category")]
[DisplayName("Category"), InstanceName("Category")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class CategoryRow : Row<CategoryRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(45), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Descrption"), Size(200), NotNull]
    public string Descrption { get => fields.Descrption[this]; set => fields.Descrption[this] = value; }

    [DisplayName("Photo"), Size(200), NotNull]
    public string Photo { get => fields.Photo[this]; set => fields.Photo[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Descrption;
        public StringField Photo;

    }
}