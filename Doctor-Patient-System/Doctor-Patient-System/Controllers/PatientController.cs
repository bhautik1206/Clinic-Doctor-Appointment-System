using Doctor_Patient_System.Models;
using Doctor_Patient_System.Models.Entities;
using EmployeeAdminPortal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doctor_Patient_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PatientController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        [Route("get-all-patient-list")]
        public IActionResult GetAllPatientList()
        {
            var PatientList = dbContext.Patients.ToList();
            return Ok(PatientList);
        }
        [HttpPost]
        [Route("add-update-patient/{id:int}")]
        public IActionResult AddOrUpdatePatient(AddPatientDTO addPatientDTo , int id)
        {
            var existencePatient = dbContext.Patients.Find(id);
            if(existencePatient!= null)
            {
                existencePatient.PName = addPatientDTo.PName;
                existencePatient.DOB = addPatientDTo.DOB;
                existencePatient.Number = addPatientDTo.Number;
                existencePatient.DoctorId = addPatientDTo.DoctorId;

                dbContext.SaveChanges();
                return Ok(existencePatient);
            }
            else
            {
                var newPatience = new Patient()
                {
                    PName = addPatientDTo.PName,
                    DOB = addPatientDTo.DOB,
                    Number = addPatientDTo.Number,
                    PatientId = addPatientDTo.PatientId,
                    DoctorId = addPatientDTo.DoctorId,
                };
                dbContext.Add(newPatience);
                dbContext.SaveChanges();
                return Ok(newPatience);
            }
        }
        [HttpGet]
        [Route("get-patient-by-id/{id:int}")]
        public IActionResult GetPatientByID(int id)
        {
            var PatientDetails = dbContext.Patients.Find(id);
            if(PatientDetails is null)
            {
                return BadRequest("Something went wrong");
            }
            return Ok(PatientDetails);
        }
        [HttpDelete]
        [Route("delete-patient-by-id/{id:int}")]
        public IActionResult DeletePatient(int id)
        {
            var DeletePatient = dbContext.Patients.Find(id);
            if(DeletePatient is null)
            {
                return BadRequest("Something went wrong");
            }
            dbContext.Patients.Remove(DeletePatient);
            return Ok("Delete sucessfully");
        }
            
    }
}
