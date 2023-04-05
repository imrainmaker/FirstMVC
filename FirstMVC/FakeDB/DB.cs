using FirstMVC.Models;

namespace FirstMVC.FakeDB
{
    public static class DB
    {
        static List<User> users = new List<User>
        {
            new User(1, "Alice", "Dupont", "alice.dupont@email.com", "Jt8L$ndm&kFq24cS",new List<string>{"La La Land", "Inception"}),
            new User(2, "Bob", "Martin", "bob.martin@email.com","5Gh#zBvKw3PxYrE"),
            new User(3, "Charlie", "Nguyen", "charlie.nguyen@email.com", "fT7#eRm2QxLz9Dy$", new List<string> { "The Shawshank Redemption" }),
            new User(4, "David", "Lee", "david.lee@email.com","V6b$UwPcNz @hM8xK"),
            new User(5, "Emma", "Garcia", "emma.garcia@email.com","aH5%kXjL9$qBm2W", new List<string> { "Cast Away", "Apocalypse Now", "Coktail" }),
            new User(6, "Frank", "Chen", "frank.chen@email.com", "qJ9@fM8cWu5$xLrE"),
            new User(7, "Grace", "Wong", "grace.wong@email.com","7Km&zRb#vGy2hNj", new List<string> { "The Godfather", "The Godfather: Part II", "The Dark Knight", "Schindler's List", "The Lord of the Rings: The Return of the King" }),
            new User(8, "Henry", "Zhang", "henry.zhang@email.com","T4c#nSv@wGj2RkF"),
            new User(9, "Isabella", "Lopez", "isabella.lopez@email.com","H8f$kL3q#sVp9Xy"),
            new User(10, "Jack", "Kim", "jack.kim@email.com", "3ZgY*6tLx#pVfDhN",new List<string> { "The Godfather", "The Dark Knight" })
        };
        public static List<User> AddUser(User? user = null)
        {

            if(user is null)
            {
                return users;
            }

            users.Add(user);
            return users;
        }
    }
}
