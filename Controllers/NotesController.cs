using System.Linq;
using System.Threading.Tasks;
using beanstalk_net.DataAccess;
using beanstalk_net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace beanstalk_net.Controllers
{
    public class NotesController : Controller
    {
        private readonly ILogger<NotesController> _logger;
        private AppDbContext _dbContext;

        public NotesController(
            ILogger<NotesController> logger,
            AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext; 
        }
            
           

        public async Task<IActionResult> Index()
        {
            var notes = await _dbContext.Notes
                .Select(note => new NoteViewModel
            {
                Id = note.Id,
                CreatedOn = note.CreatedOn,
                UpdatedOn = note.UpdatedOn,
                Content = note.Content
            }).ToListAsync();

            var notesViewModel = new NotesViewModel {Notes = notes};
            
            return View(notesViewModel);
        }
    }
}