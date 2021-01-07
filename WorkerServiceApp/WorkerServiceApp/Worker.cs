using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerServiceApp
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ITestService _testService;

        public Worker(ILogger<Worker> logger,ITestService testService)
        {
            _logger = logger;
            _testService = testService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation(_testService.Message(), DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
