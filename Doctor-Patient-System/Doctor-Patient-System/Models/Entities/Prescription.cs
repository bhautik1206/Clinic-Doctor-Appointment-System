namespace Doctor_Patient_System.Models.Entities
{
    public class Prescription
    {
        public required int PrescriptionId { get; set; }
        public required int AppointmentId { get; set; }
        public string ? Notes { get; set; }
        public DateOnly ? DateIssue { get; set; }
    }
}
