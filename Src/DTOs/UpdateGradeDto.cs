using System.ComponentModel.DataAnnotations;

namespace GradesService.Src.DTOs.UpdateGradeDto{
    public class UpdateGradeDto{
        [Required]
        public Guid Uuid { get; set;}
        public string ? SubjectName {get; set;}
        public string ? GradeName {get; set;}
        [Range(1,7,ErrorMessage = "El valor de la calificación debe estar entre 1 y 7")]
        public int ? GradeValue {get; set;}
        public string ? Comment {get; set;}
        [Required]
        public Guid StudentUuid {get; set;}
    }
}