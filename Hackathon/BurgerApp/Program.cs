using BurgerApp.Model;
using BurgerApp.Repository;

BurgerRepo obj1 = new BurgerRepo();
START:
Console.WriteLine("1.View All Burgers");
Console.WriteLine("2.Add to cart");
Console.WriteLine("3.View cart");
Console.WriteLine("4.Delete item from cart");
Console.WriteLine("5.update cart");
Console.WriteLine("6.Generate bill");
Console.WriteLine("--------------select choice-----------");
int option = int.Parse(Console.ReadLine());
switch (option)
{
    case 1:
        Console.WriteLine("all menu list is :");
        obj1.DisplayAll();
        goto START;
    case 2:
        Console.WriteLine("Add to cart");
        obj1.InsertIntoTable();
        goto START;
    case 3:
        Console.WriteLine("View cart");
        obj1.ViewCart();
        goto START;
    case 4:
        Console.WriteLine("Delete from cart");
        obj1.DeleteFromCart();
        goto START;
    case 5:
        Console.WriteLine("Update cart");
        obj1.UpdateCart();
        goto START;
    case 6:
        Console.WriteLine("Generate bill");
        obj1.GenBill();
        obj1.ViewBill();
        goto START;
    default:
        Console.WriteLine("close");
        break;
}

        //obj1.DisplayAll();
        //obj1.InsertIntoTable();
        //obj1.ViewCart();
        //obj1.DeleteFromCart();
        //obj1.DisplayAll();
        //obj1.UpdateCart();
//obj1.ViewCart();