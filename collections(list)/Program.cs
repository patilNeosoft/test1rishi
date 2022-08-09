using collections_list_.model;
using collections_list_.Repository;

ProductRepo productRepo = new ProductRepo();
List <Product> productlist = productRepo.GetProducts();
foreach (Product product in productlist)
{
    Console.WriteLine(product);
}

//add product to list
Console.WriteLine("new products here :");
try {
    Product Product = new Product() { Id = 3, Name = "Mobile", Price = 40000 };
   
    productRepo.Addproduct(Product);
    foreach (Product product in productlist)
    {
        Console.WriteLine(product);
    }
}

catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

//delete product
Console.WriteLine("delte product operation");
Console.WriteLine("enter item to delete ");
var itemToDel = Console.ReadLine();
Console.WriteLine(productRepo.DeleteProduct(itemToDel));

foreach (Product product in productlist)
{
    Console.WriteLine(product);
}
//update 
Console.WriteLine("enter item to update ");
var item = Console.ReadLine();
Console.WriteLine(productRepo.UpdateProduct(item));

foreach (Product product in productlist)
{
    Console.WriteLine(product);
}




//new join operation
/*List<Product> products;

products = new List<Product>() {
                new Product(){Id=1,Name="Tv",Price=50000 },
                new Product(){Id=2,Name="mobile",Price=20000 },

            };

List<Product1> products1;

products1 = new List<Product1>() {
                new Product1(){Name="Tv",Quantity=50000 },
                new Product1(){Name="mobile",Quantity=20000 },

            };

Console.WriteLine("items by quantity");
var result=  from p1 in products1
             join p in products
             on p1.Name equals p.Name
             select new
             {
                 productName = p.Name,
                 quantity = p1.Quantity
             };

Console.WriteLine(result);
*/
Product[] product2 = new Product[] {

    new Product(){Id=1,Name="Tv",Price=50000},
    new Product(){Id=1,Name="phone",Price=50000},
    new Product(){Id=1,Name="laptop",Price=50000},
    new Product(){Id=1,Name="phone",Price=50000}
};

//print items with specific price
Console.WriteLine("Enter minimum price");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Enter maximum price");
int max = int.Parse(Console.ReadLine());

Product[] products = product2.Where(P => P.Price > min && P.Price < max).ToArray();
foreach (Product a in products)
{
    Console.WriteLine(a);
}

//join operation
Product1[] product1 = new Product1[] {
     new Product1(){Name="Tv",Quantity=10},
     new Product1(){Name="laptop",Quantity=5}
};

Console.WriteLine("items by brand");
var result = from p1 in product1
             join p in product2
             on p1.Name equals p.Name
             select new
             {
                 product = p.Name,
                 quantity = p1.Quantity*p.Price
             };
foreach (var a in result)
{
    Console.WriteLine(a);
}

