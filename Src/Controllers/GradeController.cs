using GradesService.Src.Service.Interfaces;
using GradesService.Src.DTOs.GradeDto;
using Microsoft.AspNetCore.Mvc;

namespace GradesService.Src.Controller{
    public class GradeController : ControllerBase {
        
        private readonly IGradeService _service;

        public GradeController(IGradeService service){
            _service = service;
        }

        [HttpPost("assingGrade")]
        public async Task<IActionResult> AssingGrade(GradeDto grade){
            return Ok();
        }

    }
}