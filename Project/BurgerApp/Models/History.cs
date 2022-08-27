namespace BurgerApp.Models
{
    public class History
    {
        public int Id { get; set; }
        public int Burger_Id { get; set; }
        public string? User_Name { get; set; }
        public string? Burger_Name { get; set; }
        public string? Burger_Location { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public DateTime DateTime { get; set; }
    }
}
