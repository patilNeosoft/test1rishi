using methods.Repository;

Console.WriteLine("username:");
string userName =Console.ReadLine();
Console.WriteLine("password:");
string password = Console.ReadLine();

repository repo = new repository();
repo.Login(userName, password);

