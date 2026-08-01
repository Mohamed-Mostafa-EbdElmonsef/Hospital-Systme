using Hospital_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;initial catalog = Hospital_System;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(new List<Doctor>
            {
               new Doctor
             {
                 Id = 1,
                 Name = "Dr. Ahmed Hassan",
                 Image = "1.jpg",
                 Specialization = "Cardiology"
             },
             new Doctor
             {
                 Id = 2,
                 Name = "Dr. Sara Mohamed",
                 Image = "2.jpg",
                 Specialization = "Dermatology"
             },
             new Doctor
             {
                 Id = 3,
                 Name = "Dr. Omar Ali",
                 Image = "3.jpg",
                 Specialization = "Neurology"
             },
             new Doctor
             {
                 Id = 4,
                 Name = "Dr. Mariam Ibrahim",
                 Image = "4.jpg",
                 Specialization = "Pediatrics"
             },
             new Doctor
             {
                 Id = 5,
                 Name = "Dr. Youssef Mahmoud",
                 Image = "5.jpg",
                 Specialization = "Neurology"
             },
             new Doctor
             {
                 Id = 6,
                 Name = "Dr. Nour El Din",
                 Image = "6.jpg",
                 Specialization = "Neurology"
             },
             new Doctor
             {
                 Id = 7,
                 Name = "Dr. Fatma Khaled",
                 Image = "7.jpg",
                 Specialization = "Gynecology"
             },
             new Doctor
             {
                 Id = 8,
                 Name = "Dr. Karim Mostafa",
                 Image = "8.jpg",
                 Specialization = "General Surgery"
             },
             new Doctor
             {
                 Id = 9,
                 Name = "Dr. Reem Adel",
                 Image = "9.jpg",
                 Specialization = "Dermatology"
             },
             new Doctor
             {
                 Id = 10,
                 Name = "Dr. Hany Fawzy",
                 Image = "10.jpg",
                 Specialization = "Cardiology"
             }
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
