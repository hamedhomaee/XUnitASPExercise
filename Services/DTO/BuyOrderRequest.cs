using System.ComponentModel.DataAnnotations;
using XUnit.Services.CustomValidators;

namespace XUnit.Services.DTO;

public class BuyOrderRequest
{
    [Required(ErrorMessage = "Stock Symbol cannot be blank!")]
    public string? StockSymbol { set; get; }

    [Required(ErrorMessage = "Stock Name cannot be blank.")]
    public string? StockName { set; get; }

    [AgeLimit(ErrorMessage = "Date and time of order cannot be earlier than 1st Jan. 2000")]
    public DateTime DateAndTimeOfOrder { set; get; }

    [Range(1, 100000, ErrorMessage = "Quantity must be between 1 and 100000")]
    public uint Quantity { set; get; }

    [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
    public double Price { set; get; }
}