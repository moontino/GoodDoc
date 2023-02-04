using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodDoc_BackEnd.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Email { get; set; }

        public bool IsAnswered { get; set; } = false;

        public string? Answer { get; set; }

    }
}