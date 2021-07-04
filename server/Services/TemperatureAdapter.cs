using Microsoft.Extensions.Logging;
using server.Models;

namespace server.Services
{
    public class TemperatureAdapter : ITemperatureAdapter
    {
        private readonly ITemperatureConverterFactory temperatureConverterFactory;
        private readonly ILogger<TemperatureAdapter> logger;

        public TemperatureAdapter(
            ITemperatureConverterFactory temperatureConverterFactory,
            ILogger<TemperatureAdapter> logger
        )
        {
            this.temperatureConverterFactory = temperatureConverterFactory;
            this.logger = logger;
        }
        
        public TemperatureResponse Convert(TemperatureRequest request)
        {
            var converter = this.temperatureConverterFactory.GetConverterFor(request.From);
            return new TemperatureResponse 
            {
                Result = converter.Convert(request.To, request.NumberToConvert)
            };
        }
    }
}