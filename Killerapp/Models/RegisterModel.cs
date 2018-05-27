using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Register
    {
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is verplicht")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Wachtwoord")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wachtwoord is verplicht")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Wachtwoord moet minimaal uit 6 karakter bestaan !")]
        public string Password { get; set; }

        [Display(Name = "Herhaal wachtwoord")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wachtwoord is verplicht")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Wachtwoord moet minimaal uit 6 karakter bestaan !")]
        public string PasswordRepeat { get; set; }

        [Display(Name = "Voornaam")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Voornaam is verplicht")]
        [DataType(DataType.Text)]
        public string Voornaam { get; set; }

        [Display(Name = "Achternaam")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Achternaam is verplicht")]
        [DataType(DataType.Text)]
        public string Achternaam { get; set; }
    }
}
