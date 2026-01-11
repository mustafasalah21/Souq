namespace AdminP.Default;

[ConnectionKey("Default"), Module("Default"), TableName("review")]
[DisplayName("Review"), InstanceName("Review")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ReviewRow : Row<ReviewRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), Size(45), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Email"), Size(45), NotNull]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Subject"), Size(45), NotNull]
    public string Subject { get => fields.Subject[this]; set => fields.Subject[this] = value; }

    [DisplayName("Description"), Size(45), NotNull]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Email;
        public StringField Subject;
        public StringField Description;

    }
}