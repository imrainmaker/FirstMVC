using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstMVC.Models.DBContext.UsersConfig
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasCheckConstraint("CK_Email", "[Email] LIKE '%@%.%'");
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasData(

                            new User
                            {
                                Id = 1,
                                FirstName = "Alice",
                                LastName = "Dupont",
                                Email = "alice.dupont@email.com",
                                Password = "Jt8L$ndm&kFq24cS",
                                FavoriteMovie = new List<string> { "La La Land", "Inception" }
                            },
                            new User
                            {
                                Id = 2,
                                FirstName = "Bob",
                                LastName = "Martin",
                                Email = "bob.martin@email.com",
                                Password = "5Gh#zBvKw3PxYrE",
                                FavoriteMovie = null
                            },
                            new User
                            {
                                Id = 3,
                                FirstName = "Charlie",
                                LastName = "Nguyen",
                                Email = "charlie.nguyen@email.com",
                                Password = "fT7#eRm2QxLz9Dy$",
                                FavoriteMovie = new List<string> { "The Shawshank Redemption" }
                            },
                            new User
                            {
                                Id = 4,
                                FirstName = "David",
                                LastName = "Lee",
                                Email = "david.lee@email.com",
                                Password = "V6b$UwPcNz @hM8xK",
                                FavoriteMovie = null
                            },
                            new User
                            {
                                Id = 5,
                                FirstName = "Emma",
                                LastName = "Garcia",
                                Email = "emma.garcia@email.com",
                                Password = "aH5%kXjL9$qBm2W",
                                FavoriteMovie = new List<string> { "The Godfather", "The Godfather: Part II", "The Dark Knight", "Schindler's List", "The Lord of the Rings: The Return of the King" }
                            },
                            new User
                            {
                                Id = 6,
                                FirstName = "Frank",
                                LastName = "Chen",
                                Email = "frank.chen@email.com",
                                Password = "qJ9@fM8cWu5$xLrE",
                                FavoriteMovie = null
                            },
                            new User
                            {
                                Id = 7,
                                FirstName = "Grace",
                                LastName = "Wong",
                                Email = "grace.wong@email.com",
                                Password = "7Km&zRb#vGy2hNj",
                                FavoriteMovie = new List<string> { "Cast Away", "Apocalypse Now", "Coktail" }
                            },
                            new User
                            {
                                Id = 8,
                                FirstName = "Henry",
                                LastName = "Zhang",
                                Email = "henry.zhang@email.com",
                                Password = "T4c#nSv@wGj2RkF",
                                FavoriteMovie = null
                            },
                            new User
                            {
                                Id = 9,
                                FirstName = "Isabella",
                                LastName = "Lopez",
                                Email = "isabella.lopez@email.com",
                                Password = "H8f$kL3q#sVp9Xy",
                                FavoriteMovie = null
                            },
                            new User
                            {
                                Id = 10,
                                FirstName = "Jack",
                                LastName = "Kim",
                                Email = "jack.kim@email.com",
                                Password = "3ZgY*6tLx#pVfDhN",
                                FavoriteMovie = new List<string> { "The Godfather", "The Dark Knight" }
                            });
        }
    }
}
