using UserRegistration;
using System.IO;

User user = new User();
Console.WriteLine("enter user id:");
user.Id =int.Parse(Console.ReadLine());
Console.WriteLine("enter user name:");
user.Name= Console.ReadLine();
Console.WriteLine("enter city:");
user.City= Console.ReadLine();
List<User> userList = new List<User> ();
userList.Add(user);
//foreach (User item in userList) {
//    Console.WriteLine(item.Name);
//}

//string str1 = @"newfile.txt";

FileStream fs = new FileStream("newfile.txt", FileMode.Create, FileAccess.ReadWrite);
StreamWriter sw = new StreamWriter(fs);
StreamReader sr = new StreamReader(fs);
foreach (User user1 in userList)
{
    sw.WriteLine($"{user1.Id}{user1.Name}{user1.City}");
}


sw.Close();
fs.Close();
