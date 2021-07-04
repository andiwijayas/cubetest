using Microsoft.Extensions.Logging;

public class CelsiusConverter : ITemperatureConverter
{
    public float Convert(TemperatureType TempType, float NumberToConvert)
    {
        switch (TempType)
        {
            case TemperatureType.Fahrenheit: return (float)(1.8 * NumberToConvert);
            case TemperatureType.Kelvin:  return (float)(NumberToConvert + 273.15);
            default: return NumberToConvert;
        }
    }
}