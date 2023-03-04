using XUnit.ServiceContracts.DTO;

namespace XUnit.ServiceContracts;

public interface IStockService
{
    Task<IBuyOrderResponse?> CreateBuyOrderAsync(IBuyOrderRequest? buyOrderRequest);

    Task<ISellOrderResponse?> CreateSellOrderAsync(ISellOrderRequest? sellOrderRequest);

    Task<List<IBuyOrderResponse?>> GetBuyOrdersAsync();

    Task<List<ISellOrderResponse?>> GetSellOrdersAsync();
}