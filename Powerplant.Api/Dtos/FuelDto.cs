using System.Text.Json.Serialization;

namespace Powerplant.Api.Dtos
{
    public class FuelDto
    {
        [JsonPropertyName("gas(euro/MWh)")]
        public decimal Gas { get; set; }
 
        [JsonPropertyName( "kerosine(euro/MWh)")]
        public decimal Kerosine { get; set; }

        [JsonPropertyName( "co2(euro/ton)")]
        public decimal Co { get; set; }
   
        [JsonPropertyName( "wind(%)")]
        public decimal Wind { get; set; }
    }
}