
using polymorphismExe;
Ebook ebook = new Ebook();
ebook.ViewDetails("abs","ab");
ebook.ViewDetails("abs", "ab", 100);

//static binding
Book book = new Ebook();
//we can call child by giving reference to parent object but neccessary to use
//override keyword with virtual(base or parent class) and override(in child class) keyword
Console.WriteLine(book.OrderStatus());
