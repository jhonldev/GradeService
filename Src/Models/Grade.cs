using System.ComponentModel.DataAnnotations;

namespace GradesService.Src.Models{
    public class Grade{

        [Key]
        public Guid Uuid { get; set;}
        public string SubjectName {get; set;} = string.Empty;
        public string GradeName {get; set;} = string.Empty;
        public int GradeValue {get; set;}
        public string Comment {get; set;} = string.Empty;
        public Guid StudentUuid {get; set;}

        public Grade(){
        Uuid = Guid.NewGuid();
        }
    }
}