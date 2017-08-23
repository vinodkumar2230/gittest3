using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5.Repository.Entity
{
     public class Empl1
    {
        public int Id { get; set; }

        [Display(Name = "Enter Name")]
        [Required(ErrorMessage = "Please Enter your Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email-Id is Required")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "PhoneNumber is Required")]

        public string Phone { get; set; }
        [Required]
        public bool Maritalstatus { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "StateName is Required")]
        public string State { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "CityName is Required")]
        public string City { get; set; }
    }
}
