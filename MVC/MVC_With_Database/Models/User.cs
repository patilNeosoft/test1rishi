using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_With_Database.Models
{
    public class User
    {
        //key is capital
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string UseName { get; set; }  
        public string Phone { get; set; }
        public string Password { get; set; }

    }
}
