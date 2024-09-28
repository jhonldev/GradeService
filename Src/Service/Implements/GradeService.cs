
using AutoMapper;
using GradesService.Src.DTOs.GradeDto;
using GradesService.Src.DTOs.UpdateGradeDto;
using GradesService.Src.Models;
using GradesService.Src.Repositories.Interfaces;
using GradesService.Src.Service.Interfaces;

namespace GradesService.Src.Service.Implements{

    public class GradeService : IGradeService{
        private readonly IGradeRepository _repository;
        private readonly IMapper _mapper;

        public GradeService(IGradeRepository repository, IMapper mapper){
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<Guid> AssignGrade(GradeDto gradeDto){
            var grade = _mapper.Map<Grade>(gradeDto);
            Guid idGrade = await _repository.AssignGrade(grade);
            if(idGrade != Guid.Empty){
                return grade.Uuid;
            }
            return Guid.Empty;
        }

        public async Task<bool> UpdateGrade(UpdateGradeDto updateGradeDto){
            Grade grade = await _repository.GetGrade(updateGradeDto.Uuid);
            if(grade == null){
                return false;
            }
            if(updateGradeDto.StudentUuid != grade.StudentUuid){
                return false;
            }
            _mapper.Map(updateGradeDto, grade);
            return await _repository.UpdateGrade(grade);
        }

        public async Task<Grade[]> GetGrade(){
            return await _repository.GetGrade();
        }
    }
}