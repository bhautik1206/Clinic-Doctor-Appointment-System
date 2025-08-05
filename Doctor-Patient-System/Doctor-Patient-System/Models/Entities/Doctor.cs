namespace Doctor_Patient_System.Models.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public required string Name { get; set; }
        public required string Specialization { get; set; }
        public string ? Email { get; set; }
        public string ? Phone { get; set; }

    }
}
