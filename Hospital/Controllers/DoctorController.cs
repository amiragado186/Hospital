using Hospital.DataAccess;
using Hospital.Models;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Hospital.Controllers
{

    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();

       
        
        public IActionResult Index(FilterVM filter)
        {
            var Doctor = _dbContext.Doctors.AsQueryable();
            if (filter.DoctorName != null)
            {
                Doctor = Doctor.Where(p => p.Name.Contains(filter.DoctorName));
            }
            if (filter.DoctorSpecialization != null)
            {
                Doctor=Doctor.Where (a=>a.Specialization.Contains(filter.DoctorSpecialization));
            }
            ViewBag.Specializations = _dbContext.Doctors;
            ViewBag.TotalPages =(int) Math.Ceiling(Doctor.Count()/3.0);
            Doctor=Doctor.Skip((filter.Page-1)*3).Take(3);
            return View(Doctor.ToList());
        }

       // [HttpGet]
        public IActionResult Book(int id)
        {
            var Doctor = _dbContext.Doctors.Find(id);
            return View(Doctor);
        }
 
        [HttpPost]
        public IActionResult Book(Patient P,int id,DateOnly date,TimeOnly time)
        {
            Patient Pat=new Patient { Name= P.Name ,Gender=P.Gender,DateofBirth=P.DateofBirth};
            _dbContext.Patients.Add(Pat);
            _dbContext.SaveChanges();
            Appointment A=new Appointment { PatientId=Pat.Id,DoctorId=id,Date=date,Time=time};
            _dbContext.appointments.Add(A);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index),nameof(Appointment));
        }

    }
}
