using Microsoft.Extensions.Logging;

namespace server.Services
{
    public class TemperatureConverterFactory : ITemperatureConverterFactory
    {
        private readonly ILogger<TemperatureConverterFactory> logger;
        public TemperatureConverterFactory(ILogger<TemperatureConverterFactory> logger)
        {
            this.logger = logger;
        }
        
        public ITemperatureConverter GetConverterFor(TemperatureType type)
        {
            switch (type)
            {
                case TemperatureType.Celsius: return new CelsiusConverter();
                case TemperatureType.Kelvin: return new KelvinConverter();
                case TemperatureType.Fahrenheit: return new FahrenheitConverter();
                default: throw new UnknownTemperatureConverterException();
            }
        }
    }
}