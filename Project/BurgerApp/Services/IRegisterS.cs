using BurgerApp.Models;

namespace BurgerApp.Services
{
    public interface IRegisterS
    {
        
        public void RegisterUser(Register user);
        //change1
        Register LoginAdmin(Register user);
        Register LoginUser(Register user);
        List<Burger> GetAllBurgers();
        List<Burger> AllBurgers();
        public void AddBurger(Burger burger);
        void DeleteBurger(int id);
        Burger FindRecordById(int id);
        Cart FindRecordByIdAndNameCart(int id, string User_Name);

        List<Cart> FindRecordByIdAndNameCart1(string User_Name);
        public Cart FindRecordByIdInCart(int id);
        public bool Edit(Burger burger);
        void AddToCart(int id,string name);
        bool Buy(int id, string name,int Quantity);
        List<Buy> ViewBill(string name);
        void RemoveCartItem(int id, string User_Name);
        List<Cart> ViewCart( string name);
        public void History(int id, string User_Name);

        //public void EditCart(Cart cart);
        public void RemoveFromBill(int id, string name);


    }
}
