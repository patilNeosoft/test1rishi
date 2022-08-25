using System.ComponentModel.DataAnnotations;

namespace Burger_With_Database_MVC.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]{5,12}$", ErrorMessage = "username must be of 5 to 12 length with no special characters") ]
        public string UserName { get; set; }
        [RegularExpression(@"^\\+?[1 - 9][0 - 9]{7, 14}$", ErrorMessage ="phone number must contain exactly 10 numbers only")]
        public string Phone { get; set; }
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])){4,12}$", ErrorMessage = "password must contain atleast 1 uppercase, 1 lowercase, 1 special character and 1 digit ")]
        public string Password { get; set; }
        
    }
}
