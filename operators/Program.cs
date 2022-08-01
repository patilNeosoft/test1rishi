int productPrice = 2000;
int quantity = 2;
int discount;
double gst = 0.18 * productPrice;

if (productPrice > 500)
{
    discount = 50;
}
else {
    discount = 0;
}
double total = Math.Round((productPrice * quantity) - discount + gst);
Console.WriteLine(total);



string course = "html";
int age = 19;
if (course == "html" && age == 18)
{
    Console.WriteLine("valid");
}
else {
    Console.WriteLine("invalid");
}


string course1 = "html";
string course2="css";
if (course1 == "html" || course2 == "css")
{
    Console.WriteLine("valid");
}
else
{
    Console.WriteLine("invalid");
}

//default values
int a = default;
float b = default;
string c = default;
char d = default;
float e = default;
Console.WriteLine(a);
Console.WriteLine(b);
//nothing will be printed for string.it returns noting
Console.WriteLine(c);
//empty for char also
Console.WriteLine(d);
Console.WriteLine(e);




