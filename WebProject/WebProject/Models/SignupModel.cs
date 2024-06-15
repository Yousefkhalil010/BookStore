using System.Globalization;

namespace WebProject.Models
{
    public class SignupModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Country { get; set;  }
        public DateOnly DOB { get; set; }

    }
}
