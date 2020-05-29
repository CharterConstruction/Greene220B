using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }
        public bool? WillAttend { get; set; }
    }
}
