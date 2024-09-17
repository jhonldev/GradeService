using GradesService.Src.Service.Interfaces;
using GradesService.Src.DTOs.GradeDto;
using GradesService.Src.DTOs.UpdateGradeDto;
using Microsoft.AspNetCore.Mvc;

namespace GradesService.Src.Controller{
    [ApiController]
    [Route("api/[controller]")]
    public class GradeController : ControllerBase {
        
        private readonly IGradeService _service;

        public GradeController(IGradeService service){
            _service = service;
        }

        [HttpPost("assignGrade")]
        public async Task<IActionResult> AssignGrade(GradeDto grade){
            bool result = await _service.AssignGrade(grade);
            if(result){
                return Ok();
            }
            return BadRequest("hubo un error al asignar la calificación");
        }

        [HttpPut("updateGrade")]
        public async Task<IActionResult> UpdateGrade(UpdateGradeDto updateGrade){
            bool result = await _service.UpdateGrade(updateGrade);
            if(result){
                return Ok();
            }
            return BadRequest("hubo un error al actualizar la calificación, calificación no encontrada o no pertenece al estudiante");
        }


    }
}