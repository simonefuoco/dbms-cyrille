using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dbms_cyrille.Models
{
    public class LoginPostgresViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Hostname")]
        public string? Hostname { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string? Username { get; set; }

        [Required]
        [Display(Name = "DBname")]
        public string? DBname { get; set; }

        [Required]
        [Display(Name = "Port")]
        public int Port { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }  
}

