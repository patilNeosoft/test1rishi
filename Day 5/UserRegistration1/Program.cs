using UserRegistration1.Model;
using UserRegistration1.Repository;

UserRepo obj1 = new UserRepo();
IUserRepo obj2 = (IUserRepo)obj1;
//directly passing values from user model to interface for creating method
User user = new User();
Console.WriteLine("enter user id");
user.Id = int.Parse(Console.ReadLine());
Console.WriteLine("enter user name");
user.Name = Console.ReadLine();
Console.WriteLine("enter user city");
user.City = Console.ReadLine();

bool resultR = obj2.Register(user);
if (resultR)
{
    Console.WriteLine("registration done !");
}
else
{
    Console.WriteLine("username already exists!");
}

List<string> AllUserData=obj1.ReadData("userdata.txt");
foreach (string data in AllUserData) { 
    Console.WriteLine(data);
}