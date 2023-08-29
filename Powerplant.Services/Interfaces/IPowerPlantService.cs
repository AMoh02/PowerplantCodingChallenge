using Powerplant.Services.Models;


namespace Powerplant.Services.Interfaces
{
    public interface IPowerPlantService
    {
        public IEnumerable<PowerResult> GetPowerPlan(IEnumerable<PowerPlant> powerPlants, Fuel fuel, decimal load);
        public IEnumerable<PowerPlant> CalculateCostPlan(IEnumerable<PowerPlant> powerPlants, Fuel fuel);
        public decimal GetCostByFuel(PowerPlant powerPlant, Fuel fuel);
        public IEnumerable<PowerResult> CalculatePowerPlanResult(IEnumerable<PowerPlant> powerPlants, decimal planLoad);
    }
}
