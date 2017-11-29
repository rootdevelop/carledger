using System;
using Newtonsoft.Json;

namespace Carledger.Models
{
    public class MileageTransaction
    {
        [JsonProperty("$class")]
        public string Class { get; set; } 
        
        [JsonProperty("asset")]
        public string Asset { get; set; }
        
        [JsonProperty("newMileage")]
        public string NewMileage { get; set; }
        
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
        
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }
    }
}