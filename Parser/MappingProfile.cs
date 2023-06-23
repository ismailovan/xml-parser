using AutoMapper;
using Entities.DataTransferObjects;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Entities;
namespace Parser
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 
            CreateMap<Entities.Models.MetData, MetDataDTO>();
            CreateMap<MetDataXml, Entities.Models.MetData>();
        }

        
    }
}
