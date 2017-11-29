using Newtonsoft.Json;

namespace Carledger.Models
{
    public class Owner
    {
        [JsonProperty("$class")]
        public string Class { get; set; } 
        
        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }
        
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        
        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }
}