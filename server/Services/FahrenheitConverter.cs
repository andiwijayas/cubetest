using Microsoft.Extensions.Logging;

public class FahrenheitConverter : ITemperatureConverter
{
    public float Convert(TemperatureType TempType, float NumberToConvert)
    {
        switch (TempType)
        {
            case TemperatureType.Celsius: return (float)((NumberToConvert-32) * (5/9));
            case TemperatureType.Kelvin:  return (float)((NumberToConvert-32) * (5/9) + 273.15);
            default: return NumberToConvert;
        }
    }
}
