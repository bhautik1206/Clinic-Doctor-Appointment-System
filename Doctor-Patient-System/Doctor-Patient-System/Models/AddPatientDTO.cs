namespace Doctor_Patient_System.Models
{
    public class AddPatientDTO
    {
        public required int PatientId { get; set; }
        public required string PName { get; set; }
        public required DateOnly DOB { get; set; }
        public string? Number { get; set; }
        public int DoctorId { get; set; }
    }
}
