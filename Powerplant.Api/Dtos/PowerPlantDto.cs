using Powerplant.Api.Types;
using System.Text.Json.Serialization;

namespace Powerplant.Api.Dtos
{
    public class PowerPlantDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

   
        [JsonPropertyName("type")]

        public PowerPlantType Type { get; set; }


        [JsonPropertyName("efficiency")]
        public decimal Efficiency { get; set; }


        [JsonPropertyName("pmin")]
        public decimal PMin { get; set; }


        [JsonPropertyName("pmax")]
        public decimal PMax { get; set; }

    }
}