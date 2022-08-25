using System.ComponentModel.DataAnnotations;

namespace Burger_With_Database_MVC.Models
{
    public class Burger
    {
        [Key]
        public int BId { get; set; }
        public string BName { get; set; }
        public string BLocation { get; set; }   
        public int BPrice { get; set; }
        public int BQuantity { get;set; }

    }
}
