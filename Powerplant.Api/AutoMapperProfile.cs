using AutoMapper;
using Powerplant.Api.Dtos;
using Powerplant.Api.Models;


namespace Powerplant.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FuelDto, Fuel>().ReverseMap();
            CreateMap<PowerPlantDto, PowerPlant>().ReverseMap();

        }
    }
}
