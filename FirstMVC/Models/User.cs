using System.Reflection;

namespace FirstMVC.Models
{
    public class User
    {
        //modif
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string>? FavoriteMovie { get; set; }
        public User( int id,string firstName, string lastName, string email, string password, List<string>? favoriteMovie = null)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            FavoriteMovie = favoriteMovie;

        }
    }
}
