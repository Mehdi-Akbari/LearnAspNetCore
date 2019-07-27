using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LearnASPNetCore.Models
{
    public class Person
    {
        
        [Required(ErrorMessage ="Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your marriage status.")]
        public bool? Married { get; set; }

    }
}
