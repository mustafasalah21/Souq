using MyRow = AdminP.Modules.Default.Cart.CartRow;

namespace AdminP.Modules.Default.Cart.RequestHandlers;

public interface ICartRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class CartRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    ICartRetrieveHandler
{
}