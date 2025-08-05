using Doctor_Patient_System.Models;
using Doctor_Patient_System.Models.Entities;
using EmployeeAdminPortal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doctor_Patient_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PrescriptionController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        [Route("get-all-prescriptions")]
        public IActionResult getAllPrescription()
        {
            var pres = dbContext.Prescriptions.ToList();
            return Ok(pres);
        }
        [HttpGet]
        [Route("get-prescription-by-id")]
        public IActionResult GetPrescriptionByID(int Id)
        {
            var presecriptionId = dbContext.Prescriptions.Find(Id);
            if(presecriptionId is null)
            {
                return NotFound();
            }
            return Ok(presecriptionId);
        }
        [HttpPost]
        [Route("add-prescription")]
        public IActionResult AddPrecription(PrescriptionDTO prescritionDTO)
        {
            var perscriptionEntity = new Prescription()
            {
                AppointmentId = prescritionDTO.AppointmentId,
                PrescriptionId = prescritionDTO.PrescriptionId,
                Notes = prescritionDTO.Notes,
                DateIssue = DateOnly.FromDateTime(DateTime.Today)
            };
            dbContext.Prescriptions.Add(perscriptionEntity);
            return Ok(perscriptionEntity);
        }
    }   
}
