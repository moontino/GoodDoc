using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodDoc_BackEnd.Models
{
    public class Hospital
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public TypeOfHospitals TypeOfHospitals { get; set; }

    }
}