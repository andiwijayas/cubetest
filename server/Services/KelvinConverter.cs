using Microsoft.Extensions.Logging;

public class KelvinConverter : ITemperatureConverter
{
    public float Convert(TemperatureType TempType, float NumberToConvert)
    {
        switch (TempType)
        {
            case TemperatureType.Fahrenheit: return (float)((NumberToConvert-32) * (5/9) + 273.15);
            case TemperatureType.Celsius:  return (float)(NumberToConvert - 273.15);
            default: return NumberToConvert;
        }
    }
}