using FirstMVC.FakeDB;
using FirstMVC.Models;
using FirstMVC.Repository.Interfaces;

namespace FirstMVC.Repository.Repositories
{
    public class FakeDBUserRepository : IUserRepository
    {

        public IEnumerable<User> Get()
        {
            return DB.users.OrderBy(u => u.Id).ToList();
        }

        public User GetById(int id)
        {
            User user = DB.users.Find(u => u.Id == id);
            return user;
        }

        public bool Delete(User user)
        {
            return DB.users.Remove(user);
        }

        public User? Update(User user)
        {
            try
            {
                User userToReplace = DB.users.Find(u => u.Id == user.Id);
                DB.users.Remove(userToReplace);
                DB.users.Add(user);
                return user;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public User? CreateUser(User user)
        {
            DB.users.Add(user);
            return user;
        }
    }
}