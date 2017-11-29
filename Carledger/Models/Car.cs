using Newtonsoft.Json;

namespace Carledger.Models
{
    public class Car
    {
        [JsonProperty("$class")]
        public string Class { get; set; }
        
        [JsonProperty("carId")]
        public string CarId { get; set; }
        
        [JsonProperty("licensePlate")]
        public string Licenceplate { get; set; }
        
        [JsonProperty("make")]
        public string Make { get; set; }
        
        [JsonProperty("model")]
        public string Model { get; set; }
        
        [JsonProperty("owner")]
        public string Owner { get; set; }
        
        [JsonProperty("mileage")]
        public string Mileage { get; set; }
    }
}