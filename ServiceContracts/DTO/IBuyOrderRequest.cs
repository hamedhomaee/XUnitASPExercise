namespace XUnit.ServiceContracts.DTO;

public class IBuyOrderRequest
{
    public string? StockSymbol { set; get; }

    public string? StockName { set; get; }

    public DateTime DateAndTimeOfOrder { set; get; }

    public uint Quantity { set; get; }

    public double Price { set; get; }
}