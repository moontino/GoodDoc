using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodDoc_BackEnd.Models
{
    public class AppointmentSlot
    {
        public AppointmentSlot()
        {
            this.Id = Guid.NewGuid().ToString();
            this.AppointmentPatient = new HashSet<AppointmentPatient>();
        }
        public string Id { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public string Description { get; set; }

        public Patient Patient { get; set; }

        public string? PatientId { get; set; }

        public Status Status { get; set; }

        public Symptom Symptom { get; set; }

        public int SymptomId { get; set; }

        public IEnumerable<AppointmentPatient> AppointmentPatient { get; set; }
    }
}