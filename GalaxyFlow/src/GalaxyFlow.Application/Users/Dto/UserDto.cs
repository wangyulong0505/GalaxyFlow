using Abp.AutoMapper;

namespace GalaxyFlow.Users.Dto
{
    [AutoMapFrom(typeof(Entities.Users))]
    public class UserDto
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
