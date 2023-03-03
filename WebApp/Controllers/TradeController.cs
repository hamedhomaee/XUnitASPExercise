using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using XUnit.ServiceContracts;
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

    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}