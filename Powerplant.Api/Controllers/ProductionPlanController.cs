using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Powerplant.Api.Dtos;
using Powerplant.Api.Interfaces;
using Powerplant.Api.Models;

namespace Powerplant.Api.Controllers
{
    [ApiController]
    [Route("api/productionplan")]
    public class ProductionPlanController : ControllerBase
    {
        private readonly IPowerPlantService _powerPlantService;
        private readonly IMapper _mapper;

        public ProductionPlanController(IPowerPlantService powerPlantService, IMapper mapper)
        {
            _powerPlantService = powerPlantService;
            _mapper = mapper;
        }

        [HttpPost()]
        public IActionResult ProductionPlan([FromBody] CalculateProductionPlanRequestDto calculateProductionPlanRequest)
        {
            var powerPlants = calculateProductionPlanRequest.PowerPlants.Select(x => _mapper.Map<PowerPlant>(x));

            var fuel = _mapper.Map<Fuel>(calculateProductionPlanRequest.Fuels);

            return Ok(_powerPlantService.GetPowerPlan(powerPlants, fuel, calculateProductionPlanRequest.Load));
        }
    }
}
