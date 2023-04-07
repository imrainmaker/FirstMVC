using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVC.Models
{
    public class User
    {
        //modif
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [MaxLength(100)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(100)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(100)]
        [Required]
        public string Email { get; set; }
        [MaxLength(100)]
        [Required]
        public string Password { get; set; }
        [NotMapped]
        public List<string>? FavoriteMovie { get; set; }
        public User()
        {

        }
        public User( /*int id,*/string firstName, string lastName, string email, string password, List<string>? favoriteMovie)
        {
            //Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            FavoriteMovie = favoriteMovie;

        }
    }
}
