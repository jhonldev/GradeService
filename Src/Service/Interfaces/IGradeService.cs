using GradesService.Src.DTOs.GradeDto;
using GradesService.Src.DTOs.UpdateGradeDto;
using GradesService.Src.Models;

namespace GradesService.Src.Service.Interfaces
{
    public interface IGradeService{
        Task<Guid> AssignGrade(GradeDto grade);

        Task<bool> UpdateGrade(UpdateGradeDto updateGrade);

        Task<Grade[]> GetGrade();
    }
}