using Microsoft.EntityFrameworkCore;
using LabResultsExercise.Models;

namespace LabResultsExercise.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<LabResult> LabResults { get; set; }
    }
}