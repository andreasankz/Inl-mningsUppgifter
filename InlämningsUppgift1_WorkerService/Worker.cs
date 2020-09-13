using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using InlämningsUppgift1_WorkerService.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace InlämningsUppgift1_WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;


        private TempData _tempData; 

        
        
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _tempData = new TempData();
            _logger.LogInformation("The service have started!");


            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            
            _logger.LogInformation("The service have stopped!");
            
            return base.StopAsync(cancellationToken);
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                 int rTemperatur = _tempData.Temperatur;

                if (rTemperatur >= 25)
                    _logger.LogInformation($"The temperatur is {rTemperatur} and its to high!");
                else
                    _logger.LogInformation($"The temperatur is {rTemperatur} and its normal! ");
                
                
                
                await Task.Delay(2*1000, stoppingToken);
            }
        }

        
    }
}
