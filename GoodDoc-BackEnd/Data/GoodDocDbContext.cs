using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodDoc_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodDoc_BackEnd.Data
{
    public class GoodDocDbContext : DbContext
    {
        public GoodDocDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Dossier> Dossier { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Specialty> Specialties { get; set; }

        public DbSet<AppointmentSlot> Appointments { get; set; }

        public DbSet<AppointmentPatient> AppointmentPatients { get; set; }

        public DbSet<Symptom> Symptoms { get; set; }

    }
}