using CollectionSortedList;
using System.Collections;

Console.WriteLine("sorted list :");
SortedList sortedList = new SortedList();
sortedList.Add(101,new Student {Id=22,Name="Pooja",Age=22 });
sortedList.Add(100, new Student { Id = 90, Name = "Payal", Age = 10 });
foreach (DictionaryEntry student in sortedList)
{
//with student it will return only object not values.key is 101 suppose and other student object is value
    Console.WriteLine(student.Value);
}