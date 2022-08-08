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
Console.WriteLine("enter item to delete ");
var item = Console.ReadLine();
Console.WriteLine(productRepo.UpdateProduct(item));

foreach (Product product in productlist)
{
    Console.WriteLine(product);
}

