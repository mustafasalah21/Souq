using MyRow = AdminP.Modules.Default.Cart.CartRow;

namespace AdminP.Modules.Default.Cart.RequestHandlers;

public interface ICartSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class CartSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    ICartSaveHandler
{
}