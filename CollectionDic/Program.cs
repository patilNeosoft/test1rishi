Dictionary<int, string> courses = new Dictionary<int, string>();
courses.Add(101, "C");
courses.Add(102, ".Net");
courses.Add(103, "python");
courses.Add(104, "c#");

foreach (KeyValuePair<int,string> course in courses) {
    Console.WriteLine($"Key :{course.Key}\t Values :{course.Value}");
}
Console.WriteLine($"Courses key available {courses.ContainsKey(100)}");
var itemRemove = int.Parse(Console.ReadLine());
courses.Remove(itemRemove);
foreach (KeyValuePair<int, string> course in courses)
{
    Console.WriteLine($"Key :{course.Key}\t Values :{course.Value}");
}