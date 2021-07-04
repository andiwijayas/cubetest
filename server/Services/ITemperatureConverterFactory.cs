namespace server.Services
{
    public interface ITemperatureConverterFactory
    {
        ITemperatureConverter GetConverterFor(TemperatureType type); 

    }
}