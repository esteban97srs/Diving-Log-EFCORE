using AutoMapper;
using DivingLogs.Dtos;
using DivingLogs.Models;

namespace DivingLogs.Profiles{

    public class DivingLogProfile : Profile{
        
        public DivingLogProfile(){
            
            //source --> Target
            CreateMap<DivingLog,DivingLogReadDto>();
            CreateMap<DivingLogCreateDto, DivingLog>();
        }
    }
}