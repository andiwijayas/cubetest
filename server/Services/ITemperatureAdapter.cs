using server.Models;

namespace server.Services
{
    public interface ITemperatureAdapter
    {
        TemperatureResponse Convert(TemperatureRequest request);

    }
}