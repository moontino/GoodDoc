using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodDoc_BackEnd.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }


        public User User { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public Specialty Specialty { get; set; }

        public int SpecialtyId { get; set; }

        [Required]
        public string MedicalPracticeNumber { get; set; }

        public int MedicalInternship { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        public bool WorkWithChildren { get; set; } = false;

        public bool WorkWithNHIF { get; set; } = false;

        [Required]
        public string Adress { get; set; }

        public Region Region { get; set; }

        public int? RegionId { get; set; }

        public Hospital Hospital { get; set; }

        public int? HospitalId { get; set; }

        public AppointmentSlot AppointmentSlot { get; set; }

        public string AppointmentSlotId { get; set; }

        public bool Approved { get; set; } = false;

    }
}