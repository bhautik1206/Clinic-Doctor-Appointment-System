namespace Doctor_Patient_System.Models.Entities
{
    public class Appointment
    {
        public required int AppointmentId { get; set; }
        public required int PatientId { get; set; }
        public required int DoctorId { get; set; }
        public DateTime ? CreatedDate  { get; set; }
        public string ? Status { get; set; }

    }
}
