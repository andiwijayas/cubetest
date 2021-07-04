namespace server.Models
{
    public class TemperatureRequest
    {
        public TemperatureType From {get; set;} 
        public TemperatureType To {get; set;}
        public float NumberToConvert {get; set;}
    }
}