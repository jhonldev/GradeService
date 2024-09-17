
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


        public async Task<bool> AssignGrade(GradeDto gradeDto){
            var grade = _mapper.Map<Grade>(gradeDto);
            return await _repository.AssignGrade(grade);
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
    }
}