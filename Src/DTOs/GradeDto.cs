using System.ComponentModel.DataAnnotations;

namespace GradesService.Src.DTOs.GradeDto{
    public class GradeDto{
        [Required]
        public string SubjectName {get; set;} = string.Empty;
        [Required]
        public string GradeName {get; set;} = string.Empty;
        [Required]
        [Range(1,7,ErrorMessage = "El valor de la calificación debe estar entre 1 y 7")]
        public float GradeValue {get; set;}
        [Required]
        public string Comment {get; set;} = string.Empty;
        [Required]
        public Guid StudentUuid {get; set;}
    }
}