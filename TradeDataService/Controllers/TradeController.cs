using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TradeDataService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradePortfolioController : ControllerBase
    {
        private readonly ILogger<TradePortfolioController> _logger;

        public TradePortfolioController(ILogger<TradePortfolioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Trade> Get()
        {
            //string filePath = @"C:\Users\User\TradeDataService\TradeDataService\TradeDataService\TradePortfolio.txt";
            //string filePath = @".\TradePortfolio.txt";
            string filePath = @"TradePortfolio.txt";
            var jsonText = System.IO.File.ReadAllText(filePath);
            var trades = JsonConvert.DeserializeObject<IList<Trade>>(jsonText);
            return trades;
        }
    }
}
