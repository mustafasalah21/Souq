using MyRow = AdminP.Modules.Default.Cart.CartRow;

namespace AdminP.Modules.Default.Cart.RequestHandlers;

public interface ICartDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class CartDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    ICartDeleteHandler
{
}