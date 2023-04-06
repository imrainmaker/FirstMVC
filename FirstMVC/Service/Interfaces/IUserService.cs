using FirstMVC.Models;
using FirstMVC.Models.DTO;

namespace FirstMVC.Service.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> Get();

        User GetById(int id);

        bool Delete(int id);

        User? CreateUser(AddUserDTO user);

        User? Update(int id, UpdateUserDTO user);

        User? UpdatePassword(int id, UpdateUserPasswordDTO mdp);

    }
}
