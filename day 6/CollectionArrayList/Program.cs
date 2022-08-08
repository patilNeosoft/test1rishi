using System.Collections;

Console.WriteLine("array list in c#");

//creating arraylist
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("pooja");
arrayList.Add(true);
//access
foreach(var item in arrayList)
{
    Console.WriteLine(item);
}

//get individual item
string element = (string)arrayList[1];
Console.WriteLine(element);
//add values inser do not replace value.we can add value at that position butbecause of 
//that all other values will get shifted
arrayList.Insert(1, 200);
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

Console.WriteLine("inserrange in array");
ArrayList arrayList1 = new ArrayList() { 2, "payal",false};
arrayList.InsertRange(1, arrayList1);
foreach(var item in arrayList)
{
    Console.WriteLine(item);
}

//remove item
Console.WriteLine("iremoveat in array");
arrayList.Remove("payal");
arrayList.RemoveAt(1);
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}