using Hospital.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Appointments = _dbContext.appointments.Include(p => p.Patient).Include(d => d.Doctor).OrderBy(a => a.Date);
            
            return View(Appointments.ToList());
        }
    }
}
