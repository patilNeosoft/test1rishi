//list operations

//List<data type> list name here.

//declaration
List<int> Mylist = new List<int> { 1, 2, 3 ,4,5};
List<int> Mylist2 = new List<int> { };

//add items
Mylist.Add(6);
var items = Mylist.Count;
Console.WriteLine($"list items are:{items}");

//print all items
foreach (var item in Mylist) {
    Console.WriteLine($"all items are:{item}");
}

//add items in new list
Console.WriteLine("-----------------add item in new list------------------");

foreach (var item in Mylist)
{
    if (item>1) {
        Mylist2.Add(item);
}
   }
foreach (var item in Mylist2)
{
    Console.WriteLine($"item in new list is:{item}");
}


Console.WriteLine("-----------------remove item at specific position------------------");

foreach (var item in Mylist)
{
    if (item <3)
    {
        Mylist2.Remove(item);
    }
}
foreach (var item in Mylist2)
{
    Console.WriteLine($"item in new list is:{item}");
}


Console.WriteLine("-----------------remove item at position 1------------------");
Mylist.RemoveAt(0);
foreach (var item in Mylist)
{
    Console.WriteLine($"all items are:{item}");
}
