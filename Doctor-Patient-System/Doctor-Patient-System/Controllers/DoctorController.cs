using Doctor_Patient_System.Models;
using Doctor_Patient_System.Models.Entities;
using EmployeeAdminPortal.Data;
using Microsoft.AspNetCore.Mvc;

namespace Doctor_Patient_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public DoctorController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        [Route("get-all-doctor-details")]
        public IActionResult getAllDoctorDetails()
        {
            var doctor = dbContext.Doctor.ToList();
            return Ok(doctor);
        }
        [HttpGet]
        [Route("get-doctor-details-by-doctorID")]
        public IActionResult getDoctorDetailsByID(int id)
        {
            var doctorId = dbContext.Doctor.Find(id);
            if(doctorId is null)
            {
                return NotFound();
            }
            return Ok(doctorId);
        }
        [HttpPost]
        [Route("add-doctor")]
        public IActionResult addDoctor(AddDoctorDTO addDoctorDto)
        {
            var doctorEntity  = new Doctor()
            {
                Name = addDoctorDto.Name,
                DoctorId = addDoctorDto.DoctorId,
                Specialization = addDoctorDto.Specialization,
                Email = addDoctorDto.Email,
                Phone = addDoctorDto.Phone,
            };
            dbContext.Doctor.Add(doctorEntity);
            dbContext.SaveChanges();
            return Ok(doctorEntity);
        }
    }
}
