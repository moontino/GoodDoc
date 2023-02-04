using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodDoc_BackEnd.Models
{
    public class Patient
    {
        public Patient()
        {
            this.Id = Guid.NewGuid().ToString();
            this.AppointmentPatient = new HashSet<AppointmentPatient>();
        }

        public string Id { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        public User User { get; set; }

        [Required]
        public string UserId { get; set; }

        public Dossier File { get; set; }

        public string? FileId { get; set; }

        public IEnumerable<AppointmentPatient> AppointmentPatient { get; set; }
    }
}