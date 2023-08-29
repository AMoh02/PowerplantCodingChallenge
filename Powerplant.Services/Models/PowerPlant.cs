using Powerplant.Services.Types;

namespace Powerplant.Services.Models
{
    public class PowerPlant
    {
        public string Name { get; set; }

        public PowerPlantType Type { get; set; }

        public decimal Efficiency { get; set; }

        public decimal PMin { get; set; }

        public decimal PMax { get; set; }

        public decimal FuelCost { get; set; }


    }
}
    
