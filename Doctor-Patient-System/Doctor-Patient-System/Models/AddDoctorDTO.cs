namespace Doctor_Patient_System.Models
{
    public class AddDoctorDTO
    {
        public int DoctorId { get; set; }
        public required string Name { get; set; }
        public required string Specialization { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
