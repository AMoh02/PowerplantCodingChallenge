
using System.Text.Json.Serialization;

namespace Powerplant.Api.Dtos
{
    public class CalculateProductionPlanRequestDto
    {
        [JsonPropertyName("load")]
        public decimal Load { get; set; }

        [JsonPropertyName("fuels")]
        public FuelDto Fuels { get; set; }

        [JsonPropertyName("powerplants")]
        public IEnumerable<PowerPlantDto> PowerPlants { get; set; }
    }
}