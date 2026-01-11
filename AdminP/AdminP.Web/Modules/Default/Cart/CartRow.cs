using AdminP.Modules.Default.Product;

namespace AdminP.Modules.Default.Cart;

[ConnectionKey("Default"), Module("Default"), TableName("cart")]
[DisplayName("Cart"), InstanceName("Cart")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class CartRow : Row<CartRow.RowFields>, IIdRow
{
    const string jProduct = nameof(jProduct);

    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("User Id"), Column("UserID"), NotNull]
    public int? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Product"), NotNull, ForeignKey(typeof(ProductRow)), LeftJoin(jProduct), TextualField(nameof(ProductName))]
    [ServiceLookupEditor(typeof(ProductRow))]
    public int? ProductId { get => fields.ProductId[this]; set => fields.ProductId[this] = value; }

    [DisplayName("Quantity"), NotNull]
    public int? Quantity { get => fields.Quantity[this]; set => fields.Quantity[this] = value; }

    [DisplayName("Product Name"), Origin(jProduct, nameof(ProductRow.Name))]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field UserId;
        public Int32Field ProductId;
        public Int32Field Quantity;

        public StringField ProductName;
    }
}