using Expenese.API.Base;

namespace Expenese.API.Model
{
    public class User:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
