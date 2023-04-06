using FirstMVC.Models;

namespace FirstMVC.Repository.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> Get();

        User GetById(int id);

        bool Delete(User user);

        User? CreateUser(User user);

        User? Update(User user);
    }
}

