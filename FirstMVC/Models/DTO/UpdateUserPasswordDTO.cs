using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models.DTO
{
    public class UpdateUserPasswordDTO
    {

        [Required]
        public string Password { get; set; }

        [Required(ErrorMessage = "Ce champ est requis")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$", ErrorMessage = "Le mot de passe ne contient pas tous les éléments demandés")]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "Les mots de passe ne coresspondent pas")]
        public string CheckPassword { get; set; }
    }
}
