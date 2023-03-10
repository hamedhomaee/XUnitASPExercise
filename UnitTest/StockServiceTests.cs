using Xunit;
using Xunit.Abstractions;
using XUnit.ServiceContracts.DTO;
using XUnit.Services;

namespace XUnit.UnitTest;

public class StockServiceTests
{

    #region privateFields
    private readonly StockService _stockService;
    private readonly ITestOutputHelper _testOutputHelper;
    #endregion

    #region Constructor
    public StockServiceTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _stockService = new StockService();
    }
    #endregion

    #region CreateBuyOrderAsync_BuyOrderRequestIsNull_ThrowsArgumentNullException
    [Fact]
    public async Task CreateBuyOrderAsync_BuyOrderRequestIsNull_ThrowsArgumentNullException()
    {
        // Arrange
        IBuyOrderRequest? buyOrderRequest = null;

        // Assert
        await Assert.ThrowsAsync<ArgumentNullException>(async () =>
            {
                // Act
                await _stockService.CreateBuyOrderAsync(buyOrderRequest);
            });
    }
    #endregion

    #region CreateBuyOrderAsync_BuyOrderRequestQuantityLessThanOne_ThrowsArgumentException
    [Fact]
    public async Task CreateBuyOrderAsync_BuyOrderRequestQuantityLessThanOne_ThrowsArgumentException()
    {
        // Arrange
        IBuyOrderRequest buyOrderRequest = new();
        buyOrderRequest.Quantity = 0;

        // Assert
        await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await _stockService.CreateBuyOrderAsync(buyOrderRequest);
        });
    }
    #endregion

    #region CreateBuyOrderAsync_BuyOrderRequestQuantityMoreThanHundredThousandOne_ThrowsArgumentException
    [Fact]
    public async Task CreateBuyOrderAsync_BuyOrderRequestQuantityMoreThanHundredThousandOne_ThrowsArgumentException()
    {
        // Arrange
        IBuyOrderRequest buyOrderRequest = new();
        buyOrderRequest.Quantity = 100001;

        // Assert
        await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await _stockService.CreateBuyOrderAsync(buyOrderRequest);
        });
    }
    #endregion

    #region CreateBuyOrderAsync_BuyOrderRequestPriceLessThanOne_ThrowsArgumentException
    [Fact]
    public async Task CreateBuyOrderAsync_BuyOrderRequestPriceLessThanOne_ThrowsArgumentException()
    {
        // Arrange
        IBuyOrderRequest buyOrderRequest = new();
        buyOrderRequest.Quantity = 5;
        buyOrderRequest.Price = 0;

        // Assert
        await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await _stockService.CreateBuyOrderAsync(buyOrderRequest);
        });
    }
    #endregion

    #region CreateBuyOrderAsync_BuyOrderRequestPriceLessMoreThanTenThousandOne_ThrowsArgumentException
    [Fact]
    public async Task CreateBuyOrderAsync_BuyOrderRequestPriceMoreThanTenThousandThanOne_ThrowsArgumentException()
    {
        // Arrange
        IBuyOrderRequest buyOrderRequest = new();
        buyOrderRequest.Quantity = 5;
        buyOrderRequest.Price = 10001;

        // Assert
        await Assert.ThrowsAsync<ArgumentException>(async () =>
        {
            await _stockService.CreateBuyOrderAsync(buyOrderRequest);
        });
    }
    #endregion
}