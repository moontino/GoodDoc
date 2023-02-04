using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodDoc_BackEnd.Models
{
    public class Admin
    {
        public Admin()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }


        public User User { get; set; }

        [Required]
        public string UserId { get; set; }

        public Question Question { get; set; }

        public int? QuestionId { get; set; }


        //Doctors

    }
}