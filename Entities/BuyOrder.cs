using System.ComponentModel.DataAnnotations;

namespace XUnit.Entities;

public class BuyOrder
{
    public Guid BuyOrderID { set; get; }

    [Required(ErrorMessage = "Stock Symbol cannot be blank.")]
    public string? StockSymbol { set; get; }

    [Required(ErrorMessage = "Stock Name cannot be blank.")]
    public string? StockName { set; get; }

    public DateTime DateAndTimeOfOrder { set; get; }

    [Range(1, 100000, ErrorMessage = "Quantity must be between 1 and 100000")]
    public uint Quantity { set; get; }

    [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
    public double Price { set; get; }
}