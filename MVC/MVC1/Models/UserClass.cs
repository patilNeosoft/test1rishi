using System.ComponentModel.DataAnnotations.Schema;

namespace MVC1.Models
{
    public class UserClass
    {
       // [key, DatabaseGenerated]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }  
    }
}
