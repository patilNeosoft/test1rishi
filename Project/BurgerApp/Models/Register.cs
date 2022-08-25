using System.ComponentModel.DataAnnotations;

namespace BurgerApp.Models
{
    public class Register
    {
        public bool Role { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]{5,12}$", ErrorMessage = "username must be of 5 to 12 length with no special characters")]
        public string User_Name { get; set; }

        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "phone number must contain exactly 10 numbers only")]

        public string Mobile_Number { get; set;}


        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "password must contain atleast 1 uppercase, 1 lowercase, 1 special character and 1 digit ")]

        public string Password { get;set; }
    }
}
