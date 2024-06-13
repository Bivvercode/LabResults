using LabResultsExercise.Data;
using LabResultsExercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LabResultsExercise.Controllers
{
    [Route("api/labresults")]
    [ApiController]
    public class LabResultsController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LabResult>>> GetLabResults()
        {
            return await _context.LabResults.ToListAsync();
        }
    }
}