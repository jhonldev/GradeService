using GradesService.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace GradesService.Src.Data{
    public class DataContext : DbContext{
        public DbSet<Grade> Grades { get; set;} = null!;

        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }
    }
}