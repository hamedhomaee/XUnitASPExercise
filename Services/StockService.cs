using XUnit.ServiceContracts;
using XUnit.ServiceContracts.DTO;

namespace XUnit.Services;

public class StockService : IStockService
{
    public Task<IBuyOrderResponse> CreateBuyOrderAsync(IBuyOrderRequest? buyOrderRequest)
    {
        throw new NotImplementedException();
    }

    public Task<ISellOrderResponse> CreateSellOrderAsync(ISellOrderRequest? sellOrderRequest)
    {
        throw new NotImplementedException();
    }

    public Task<List<IBuyOrderResponse>> GetBuyOrdersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<ISellOrderResponse>> GetSellOrdersAsync()
    {
        throw new NotImplementedException();
    }
}