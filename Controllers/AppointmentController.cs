using Hospital_Management_System.Data;
using Hospital_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System.Controllers
{
    public class AppointmentController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var doctor = _context.Doctors.ToList();
           

            return View(doctor);
        }

        public IActionResult enroll(int id)
        {
            var doctor = _context.Doctors.Find(id);
            return View(doctor);
        }

        [HttpPost]
        public IActionResult enroll(int doctorId,string patientname,DateOnly appointmentdate,string appointmenttime)
        { 
            Appointment appointment = new Appointment() 
            {
                PatientName = patientname,
                DoctorId = doctorId,
                AppointmentDate = appointmentdate,
                AppoitmentTime = appointmenttime
            };

            _context.Appointments.Add(appointment);
            _context.SaveChanges();
            
            return RedirectToAction("reservation");
        }

        public IActionResult reservation()
        {
            var appointments = _context.Appointments.Include(a => a.Doctor).ToList();
            return View(appointments);
        }
    }
}
