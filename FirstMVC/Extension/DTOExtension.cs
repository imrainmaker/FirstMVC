using FirstMVC.Models;

namespace FirstMVC.Extension
{
    public static class DTOExtension
    {
        static int currentID = 10;
        public static User ToUser(this AddUserDTO userDto)
        {
            return new User(++currentID,userDto.FirstName,userDto.LastName,userDto.Email,userDto.Password);
        }

        public static UpdateUserDTO ToUserDTO(this User user)
        {
            return new UpdateUserDTO()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Id = user.ID,
            };
        }
    }
}
