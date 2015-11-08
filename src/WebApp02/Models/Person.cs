using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp02.Models
{
    public class Person
    {
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
    }
}
