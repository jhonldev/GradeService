using GradesService.Src.Models;

namespace GradesService.Src.Repositories.Interfaces{
    public interface IGradeRepository{
        Task<bool> AssignGrade(Grade grade);
        Task<Grade> GetGrade(Guid idGrade);
        Task<bool> UpdateGrade(Grade grade);
    
    }
}