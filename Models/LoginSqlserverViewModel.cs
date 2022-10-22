using System.ComponentModel.DataAnnotations;

namespace dbms_cyrille.Models
{
    public class LoginSqlserverViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Host")]
        public string? Host { get; set; }

        [Required]
        [Display(Name = "Port")]
        public int Port { get; set; }


        [Required]
        [Display(Name = "User")]
        public string? User { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        [Required]
        [Display(Name = "Database")]
        public string? Database { get; set; }



       
    }
}
