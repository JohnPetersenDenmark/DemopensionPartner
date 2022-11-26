using System.Text.Json.Serialization;

namespace DemopensionPartner.Models
{
    public class Publicpension
    {
        [JsonPropertyName("customer")]
        public ResponseCustomer customer { get; set; }
        [JsonPropertyName("spouse")]
        public ResponseSpouse spouse { get; set; }
    }


}
