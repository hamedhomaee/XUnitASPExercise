using XUnit.Entities;
using XUnit.ServiceContracts;
using XUnit.ServiceContracts.DTO;

namespace XUnit.Services;

public class StockService : IStockService
{
    #region PrivateFields
    private List<BuyOrder>? buyOrders;
    private List<SellOrder>? sellOrders;
    #endregion

    #region CreateBuyOrderAsync
    public async Task<IBuyOrderResponse?> CreateBuyOrderAsync(IBuyOrderRequest? buyOrderRequest)
    {
        if(buyOrderRequest == null)
            throw new ArgumentNullException();

        if(buyOrderRequest.Quantity < 1 || buyOrderRequest.Quantity > 100000)
            throw new ArgumentException();

        if(buyOrderRequest.Price < 1 || buyOrderRequest.Price > 10000)
            throw new ArgumentException();

        await Task.CompletedTask;
        return null;
    }
    #endregion

    #region CreateSellOrderAsync
    public async Task<ISellOrderResponse?> CreateSellOrderAsync(ISellOrderRequest? sellOrderRequest)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
    #endregion

    #region GetBuyOrderAsync
    public async Task<List<IBuyOrderResponse?>> GetBuyOrdersAsync()
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
    #endregion

    #region GetSellOrderAsync
    public async Task<List<ISellOrderResponse?>> GetSellOrdersAsync()
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
    #endregion
}