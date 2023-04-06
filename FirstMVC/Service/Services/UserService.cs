using FirstMVC.Extension;
using FirstMVC.FakeDB;
using FirstMVC.Models;
using FirstMVC.Models.DTO;
using FirstMVC.Repository.Interfaces;
using FirstMVC.Service.Interfaces;

namespace FirstMVC.Service.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public IEnumerable<User> Get()
        {
            return _userRepository.Get();
        }

        public User GetById(int id)
        {
            
            return _userRepository.GetById(id);
        }

        public bool Delete(int id)
        {
            User user = _userRepository.GetById(id);
            return _userRepository.Delete(user);
        }

        public User? Update(int id, UpdateUserDTO user)
        {
            User userUpdate = _userRepository.GetById(id);
            userUpdate.LastName = user.LastName;
            userUpdate.FirstName = user.FirstName;
            userUpdate.Email = user.Email;

            return _userRepository.Update(userUpdate);
        }

        public User? CreateUser(AddUserDTO user)
        {
            return _userRepository.CreateUser(user.ToUser());
        }

    }
}
