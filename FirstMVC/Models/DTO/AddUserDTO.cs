using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models.DTO
{
    public class AddUserDTO
    {
        [Required(ErrorMessage = "Ce champ est requis")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Ce champ est requis")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Ce champ est requis")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Ce champ est requis")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$",ErrorMessage = "Le mot de passe ne contient pas tous les éléments demandés")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Les mots de passe ne coresspondent pas")]
        public string CheckPassword { get; set; }

    }
}
