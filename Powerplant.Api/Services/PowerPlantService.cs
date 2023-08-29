using Powerplant.Api.Interfaces;
using Powerplant.Api.Models;
using Powerplant.Api.Types;
using System;


namespace Powerplant.Api.Services
{
    public class PowerPlantService : IPowerPlantService
    {

        public IEnumerable<PowerResult> GetPowerPlan(IEnumerable<PowerPlant> powerPlants, Fuel fuel, decimal load)
        {
            var powerPlantsWithFuelCost = this.CalculateCostPlan(powerPlants, fuel);

            var result = this.CalculatePowerPlanResult(powerPlantsWithFuelCost, load);

            return result;
        }

        public IEnumerable<PowerPlant> CalculateCostPlan(IEnumerable<PowerPlant> powerPlants, Fuel fuel)
        {
            List<PowerPlant> plants = new List<PowerPlant>();

            foreach (var plant in powerPlants)
            {
               
                plant.FuelCost = GetCostByFuel(plant, fuel);

                plants.Add(plant);
            }
            return plants;
        }


        public decimal GetCostByFuel(PowerPlant powerPlant, Fuel fuel)
        {
            return powerPlant.Type switch
            {
                PowerPlantType.WindTurbine => 0.0M,
                PowerPlantType.GasFired => fuel.Gas / powerPlant.Efficiency,
                _ => fuel.Kerosine / powerPlant.Efficiency
            };
        }

        public IEnumerable<PowerResult> CalculatePowerPlanResult(IEnumerable<PowerPlant> powerPlants, decimal planLoad)
        {
            var result = new List<PowerResult>();
            var load = planLoad;

            foreach (var p in powerPlants)
            {
                if (p.PMax == 0 || p.PMin > load)
                {
                    result.Add(new PowerResult()
                    {
                        Name = p.Name,
                        P = 0,
                    });

                }
                else if (load <= p.PMax && load >= p.PMin)
                {
                    result.Add(new PowerResult()
                    {
                        Name = p.Name,
                        P = Math.Round(load, 1),
                    });
                    load = 0;

                }
                else
                {
                    result.Add(new PowerResult()
                    {
                        Name = p.Name,
                        P = Math.Round(p.PMax, 1),
                    });
                        };

                load -= p.PMax;
            }

            return result;
        }
    }
}
