
using day3.Repository;
using day3.models;
//object to access repository
productRe product = new productRe();

//calling method getproduct and adding to new aray allproducts
Product[] allProducts = product.GetAllProducts();

//loop to check each item in allproduct array and printing it.
foreach (Product item in allProducts) {
    Console.WriteLine($"Name:{item.Name}\t category:{item.Category}\t price:{item.Price}\t");
}

Console.WriteLine("---------");

//loop to print product by category
foreach (Product item in allProducts) {
    if (item.Category != "Mobile")
    {
        Console.WriteLine("");
    }
    else {
        Console.WriteLine($"Name:{item.Name}\t category:{item.Category}\t price:{item.Price}\t");

    }
}

//delete product

Console.WriteLine("----------------------delete product--------------------------");
Product[] delPro = product.GetAllProducts();
foreach (Product item in delPro)
{
    if (item.Category == "Tv")
    {
        item.Category = null;
        Console.WriteLine($"Name:{item.Name}\t category:{item.Category}\t price:{item.Price}\t");
    }
    else
    {
        Console.WriteLine($"Name:{item.Name}\t category:{item.Category}\t price:{item.Price}\t");
    }
}


//update
Console.WriteLine("----------------------update product--------------------------");

Product[] upPro = product.GetAllProducts();
foreach (Product item in upPro) {
    if (item.Category != "Mobile")
    {
        item.Category = "Mobile";
       Console.WriteLine($"Name:{item.Name}\t category:{item.Category}\t price:{item.Price}\t");
    }
    else {
        Console.WriteLine($"Name:{item.Name}\t category:{item.Category}\t price:{item.Price}\t");
   }
}


//update
//foreach (Product item in allProducts)
//{
//   Console.WriteLine($"Name:{item.Name}\t category:{item.Category}\t price:{item.Price}\t");
//}





