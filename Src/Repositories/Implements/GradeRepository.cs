using GradesService.Src.Data;
using AutoMapper;
using GradesService.Src.Repositories.Interfaces;
using GradesService.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace GradesService.Src.Repositories.Implements{
    
    public class GradeRepository : IGradeRepository{

        private readonly DataContext _context;

        public GradeRepository(DataContext context, IMapper mapper){
            _context = context;
        }

        public async Task<Guid> AssignGrade(Grade grade){
            try{
                _context.Grades.Add(grade);
                await _context.SaveChangesAsync();
                return grade.Uuid;
            }
            catch(Exception ex){
                Console.WriteLine($"Error al ingresar la calificación: {ex.Message}");
                return Guid.Empty;
            }
        }

        public async Task<Grade> GetGrade(Guid idGrade){
            try{
                return await _context.Grades.FindAsync(idGrade);
            }
            catch(Exception ex){
                Console.WriteLine($"Error al obtener la calificación: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UpdateGrade(Grade grade){
            try{
                _context.Grades.Update(grade);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex){
                Console.WriteLine($"Error al ingresar la calificación: {ex.Message}");
                return false;
            }
        }

        public async Task<Grade[]> GetGrade(){
            try{
                return await _context.Grades.ToArrayAsync();
            }
            catch(Exception ex){
                Console.WriteLine($"Error al obtener las calificaciones: {ex.Message}");
                return null;
            }
        }
    }
}