using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using XUnit.ServiceContracts;
using XUnit.WebApp.Models;
using XUnit.WebApp.Options;

namespace XUnit.Controllers;

public class TradeController : Controller
{
    private readonly TradeOptions? _options;
    private readonly IFinnhubService? _finnhubService;
    private readonly IStockService? _stockService;

    public TradeController(IOptions<TradeOptions> options, IFinnhubService finnhubService, IStockService stockService)
    {
        _finnhubService = finnhubService;
        _stockService = stockService;
        _options = options.Value;
    }

    [Route("trade")]
    public async Task<IActionResult> IndexAsync()
    {
        Dictionary<string, object>? companyProfile = await _finnhubService!.GetCompanyProfileAsync(_options!.DefaultStockSymbol!);
        Dictionary<string, object>? stockPriceQuote = await _finnhubService!.GetStockPriceQuoteAsync(_options.DefaultStockSymbol!)!;

        return View(new StockTrade()
            {
                StockSymbol = _options.DefaultStockSymbol,
                StockName = companyProfile!["name"].ToString(),
                Quantity = 10,
                Price = Convert.ToInt32(stockPriceQuote!["c"].ToString())
            });
    }
}