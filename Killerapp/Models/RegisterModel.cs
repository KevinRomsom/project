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
        [MinLength(6, ErrorMessage = "Wachtwoord moet minimaal uit 6 karakters bestaan!")]
        [MaxLength(20, ErrorMessage = "Wachtwoord moet maximaal uit 20 karakters bestaan!")]
        public string Password { get; set; }

        [Display(Name = "WachtwoordRepeat")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Wachtwoord is verplicht")]
        [DataType(DataType.Password)]
        public string PasswordRepeat { get; set; }

        [Display(Name = "Voornaam")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Voornaam is verplicht")]
        [DataType(DataType.Text)]
        public string Voornaam { get; set; }

        [Display(Name = "Achternaam")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Achternaam is verplicht")]
        [DataType(DataType.Text)]
        public string Achternaam { get; set; }

        public Register(string email, string password, string passwordrepeat, string voornaam, string achternaam)
        {
            this.Email = email;
            this.Password = password;
            this.PasswordRepeat = passwordrepeat;
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
        }
    }
}
