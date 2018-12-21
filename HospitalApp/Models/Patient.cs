using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required, StringLength(20),]
        public string Name { get; set; }
         [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
