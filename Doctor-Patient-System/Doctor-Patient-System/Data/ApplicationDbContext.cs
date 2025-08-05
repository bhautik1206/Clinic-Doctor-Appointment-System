using Doctor_Patient_System.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        //public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; } 
        public DbSet<Prescription> Prescriptions { get; set; }

    }
}
