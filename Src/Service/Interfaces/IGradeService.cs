using GradesService.Src.DTOs.GradeDto;
using GradesService.Src.DTOs.UpdateGradeDto;

namespace GradesService.Src.Service.Interfaces
{
    public interface IGradeService{
        Task<bool> AssignGrade(GradeDto grade);

        Task<bool> UpdateGrade(UpdateGradeDto updateGrade);
    }
}