using FirstMVC.Models;
using FirstMVC.Models.DTO;

namespace FirstMVC.Models.Mapper
{
    public static class UserMapper
    {
        //static int currentID = 10;
        public static User ToUser(this AddUserDTO userDto)
        {
            return new User(/*++currentID,*/ userDto.FirstName, userDto.LastName, userDto.Email, userDto.Password, null);
        }

        public static UpdateUserDTO ToUserDTO(this User user)
        {
            return new UpdateUserDTO()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
            };
        }
    }
}
