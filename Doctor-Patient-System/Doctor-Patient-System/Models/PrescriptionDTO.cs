namespace Doctor_Patient_System.Models
{
    public class PrescriptionDTO
    {
        public required int PrescriptionId { get; set; }
        public required int AppointmentId { get; set; }
        public string? Notes { get; set; }
        public DateOnly? DateIssue { get; set; }
    }
}
