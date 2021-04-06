using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElasticKibanaLoggingVerify.Controllers
{
    
    public class ElasticSearchController : Controller
    {
        private readonly ILogger<ElasticSearchController> _logger;

        public ElasticSearchController(ILogger<ElasticSearchController> logger)
        {
            _logger = logger;
        }

        // GET: api/values  
        [HttpGet]
        public int GetRandomvalue()
        {
            var random = new Random();
            var randomValue = random.Next(0, 100);
            _logger.LogInformation($"Random Value is {randomValue}");
            return randomValue;
        }
    }
}
