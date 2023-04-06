using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models.DTO
{
    public class UpdateUserDTO
    {
        [Required(ErrorMessage = "Ce champ est requis")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Ce champ est requis")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Ce champ est requis")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
