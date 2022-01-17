using Microsoft.EntityFrameworkCore;

namespace CourseWork.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
    }
}
