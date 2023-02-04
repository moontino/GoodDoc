using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoodDoc_BackEnd.Models
{
    [PrimaryKey(nameof(AppointmentSlotId), nameof(PatientId))]
    public class AppointmentPatient
    {
        public AppointmentSlot AppointmentSlot { get; set; }
        public string AppointmentSlotId { get; set; }

        public Patient Patient { get; set; }

        public string PatientId { get; set; }
    }
}