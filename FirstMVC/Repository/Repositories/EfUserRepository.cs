using FirstMVC.FakeDB;
using FirstMVC.Models;
using FirstMVC.Models.DBContext;
using FirstMVC.Repository.Interfaces;

namespace FirstMVC.Repository.Repositories
{
    public class EfUserRepository : IUserRepository
    {

        private readonly DataContext _context;

        public EfUserRepository(DataContext context)
        {
            _context = context;
        }

        public User? CreateUser(User user)
        {
            try
            {
                _context.users.Add(user);
                _context.SaveChanges();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool Delete(User user)
        {

            _context.Remove(user);
            _context.SaveChanges();
            return true ;
        }

        public IEnumerable<User> Get()
        {
            return _context.users.ToList();
        }

        public User GetById(int id)
        {
            return _context.users.Find(id);
        }

        public User? Update(User user)
        {
            try
            {
                _context.users.Update(user);
                _context.SaveChanges();
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
