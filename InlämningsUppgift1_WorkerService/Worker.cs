using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using InlämningsUppgift1_WorkerService.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace InlämningsUppgift1_WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        private readonly string url = $"http://api.openweathermap.org/data/2.5/weather?q=Örebro&appid=b9f2df37033f5febf912e841800f475a&units=metric&cnt=6";
        
        private HttpClient client;

        
        
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new HttpClient();
            _logger.LogInformation("The weather service have started!");


            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            _logger.LogInformation("The weather service have stopped!");
            
            return base.StopAsync(cancellationToken);
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var data = JsonConvert.DeserializeObject<TempData.Root>(await response.Content.ReadAsStringAsync());

                        _logger.LogInformation($"In the city {data.Name.ToLower()} the temperatur is {data.Main.Temp}°C and humidity is {data.Main.Humidity}%");
                    }
                    
                }
                catch (Exception ex)
                {
                    _logger.LogInformation($"The request have failed. { ex.Message }");
                    
                }


                
                
                await Task.Delay(60*1000, stoppingToken);
            }
        }

        
    }
}
