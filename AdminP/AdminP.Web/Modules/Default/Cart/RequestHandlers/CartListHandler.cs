using MyRow = AdminP.Modules.Default.Cart.CartRow;

namespace AdminP.Modules.Default.Cart.RequestHandlers;

public interface ICartListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class CartListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    ICartListHandler
{
}