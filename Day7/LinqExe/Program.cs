using LinqExe;

Product[] product = new Product[] {

    new Product(){Name="Nokia",Category="phone",Price=3000},
    new Product(){Name="Redmi",Category="Tv",Price=30000},
    new Product(){Name="Laptop",Category="Hp",Price=50000},
    new Product(){Name="Realme",Category="phone",Price=15000}
};


//bestselars
Bestsellar[] bestsellar = new Bestsellar[] {
     new Bestsellar(){Name="Redmi",Brand="A"},
     new Bestsellar(){Name="Nokia",Brand="B"}
};




//print items with specific price
Console.WriteLine("Enter minimum price");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Enter maximum price");
int max = int.Parse(Console.ReadLine());

Product[] products = product.Where(P => P.Price > min && P.Price < max).ToArray();
foreach(Product item in products)
{
    Console.WriteLine(item);
}
//query syntax

var filterProduct = (from p in product
                     where p.Price > 200 && p.Price < 20000
                     select p).ToArray();
foreach(Product item in filterProduct)
{
    Console.WriteLine(item);
}

Console.WriteLine("get product by category..LINQ");
Product[] Products = product.Where(p => p.Category == "phone").ToArray();
foreach (Product item in products)
{
    Console.WriteLine(item);
}
Console.WriteLine("get product by category..query syntax");
var filterProductByC = (from p in product
                     where p.Category =="phone"
                     select p).ToArray();
foreach (Product item in filterProductByC)
{
    Console.WriteLine(item);
}

Console.WriteLine("name in descending order");
var orderItems = (from p in product
                  orderby p.Name descending
                  select p);
foreach (Product item in orderItems)
{
    Console.WriteLine(item);
}

//key is category name and it will have many values.so get key by for loop and again iterate through key
//to get all values
Console.WriteLine("items by category");
var groupByC = (from p in product
               group p by p.Category);
foreach(var item in groupByC)
{
    Console.WriteLine($"groupbycategory : {item.Key}");
    foreach (var item1 in item)
    {
        Console.WriteLine(item1);
    }
}

//join op product name-product rank
Console.WriteLine("items by brand");
var result = from b in bestsellar
             join p in product
             on b.Name equals p.Name
             select new
             {
                 productName = p.Name,
                 bestProductName = b.Brand
             };
foreach(var item in result)
{
    Console.WriteLine(item);
}

Console.WriteLine("--------max-------- ");
var highestPrice = product.MaxBy(p => p.Price);
Console.WriteLine(highestPrice);

Console.WriteLine("--------min=---------");
var lowestPrice = product.MinBy(p => p.Price);
Console.WriteLine(lowestPrice);

Console.WriteLine("---------Count items-------");
var countItems = product.Count();
Console.WriteLine(countItems);


