using BurgerApp.Model;
using BurgerApp.Repository;

BurgerRepo obj1 = new BurgerRepo();
START:
Console.WriteLine("1.View all menues");
Console.WriteLine("2.Get burgers by location");
Console.WriteLine("3.Add to cart");
Console.WriteLine("4.View cart");
Console.WriteLine("5.Delete item");
Console.WriteLine("6.Calculate bill ");
Console.WriteLine("--------------select choice-----------");
int option = int.Parse(Console.ReadLine());
switch (option)
{
    case 1:
        Console.WriteLine("all menu list is :");
        obj1.GetBurgers();
        
        goto START;
    case 2:
        obj1.GetBurgersByLoaction();
      
        goto START;
    case 3:
        obj1.Addproduct();
        Console.WriteLine("done");
        goto START;
    case 4:
        obj1.ViewCart();
        
        goto START;
    case 5: 
       bool a = obj1.DeleteItem();
        if (a) {
            Console.WriteLine("Burger from cart removed successfully !");
                }
        else {
            Console.WriteLine("Burger does not exist in cart !");
        }
        goto START;
    case 6:
        obj1.CalculateBill();
        
        goto START;
    default:
        Console.WriteLine("close");
        break;

}