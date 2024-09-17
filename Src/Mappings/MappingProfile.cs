using AutoMapper;
using GradesService.Src.DTOs.UpdateGradeDto;
using GradesService.Src.DTOs.GradeDto;
using GradesService.Src.Models;

namespace GradesService.Src.Mappings{
    public class MappingProfile : Profile{
        public MappingProfile(){
            CreateMap<GradeDto, Grade>();
            CreateMap<UpdateGradeDto, Grade>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}