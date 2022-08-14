using BurgerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Repository
{
    internal class BurgerRepo
    {
        List<Burger> burgers;
        List<Burger> cartItems;
        public BurgerRepo()
        {
            burgers = new List<Burger>() {
                new Burger(){Id=1,Name="Turkey Burgers",Location="Mumbai",Price=120,Quantity=5 },
                new Burger(){Id=2,Name="Veggie Burgers",Location="Panvel",Price=150,Quantity=15 },
                new Burger(){Id=3,Name="Beef Burgers",Location="Vashi",Price=70,Quantity=6 },
                new Burger(){Id=4,Name="Turkey Burgers",Location="Panvel",Price=90,Quantity=23 }

            };
            cartItems = new List<Burger>() { };
        }
        
        int total;
        internal void CalculateBill()
        {
            Console.WriteLine("enter quantity");
            int quantity = int.Parse(Console.ReadLine());
            foreach (Burger a in cartItems)
            {
                int Price = a.Price * quantity;
                total += a.Price;
                a.Quantity -= quantity;
                Console.WriteLine($"Id : {a.Id},Name : {a.Name},Location : {a.Location},Price : {Price},Quantity : {quantity}");
                Console.WriteLine($"Total Price :{total}");
                

            }


        }

        private Burger GetBurgerById(int id)
        {
            return burgers.Find(p => p.Id == id);

        }
        public void Addproduct()
        {
            Burger Cart1 = new Burger() { };
            Console.WriteLine("Enter id of burger to add to cart ");
            int id = int.Parse(Console.ReadLine());
            Cart1 = GetBurgerById(id);
            if (Cart1 == null)
            {
                Console.WriteLine("Burger does not exist in menu.Try again");
            }
            else
            {
                cartItems.Add(Cart1);
                Console.WriteLine("Burger added to cart successfully !");
            }
         }
        internal void ViewCart()
        {
            if (cartItems.Count == 0)
            {
                Console.WriteLine("cart is empty !");
            }
            else
            {
                foreach (Burger a in cartItems)
                {
                    Console.WriteLine($"Id : {a.Id},Name : {a.Name},Location : {a.Location},Price : {a.Price}");
                }
            }
        }

        
        public bool DeleteItem() {
            Console.WriteLine("enter Id of product");
            int deleteId = int.Parse(Console.ReadLine());
            var burger = GetBurgerById(deleteId);
            //if name is present then remove product
            return burger != null ? cartItems.Remove(burger) : false;

        }


        //get burgers by location
        internal void GetBurgersByLoaction()
        {
            Console.WriteLine("enter location");
            string location = Console.ReadLine();
            var AvailableBurgers = burgers.Where(p => p.Location == location).ToList();
            if (AvailableBurgers.Count == 0) {
                Console.WriteLine("not available");
            }
            else
            Console.WriteLine(" available burgers are :");
            foreach (Burger a in AvailableBurgers)
            {
                Console.WriteLine($"Id : {a.Id},Name : {a.Name},Location : {a.Location},Price : {a.Price},Quantity : {a.Quantity}");
            }
        }

        //get all burgers
        public void GetBurgers()
        {
            foreach (Burger a in burgers)
            {
                Console.WriteLine($"Id : {a.Id},Name : {a.Name},Location : {a.Location},Price : {a.Price},Quantity : {a.Quantity}");
            }
        }
        }
}
