Console.WriteLine("stacks");
Stack<string> logs= new Stack<string>();
logs.Push("pooja");
logs.Push("patil");
foreach (string log in logs) {
    Console.WriteLine(log);
}
Console.WriteLine(logs.Peek());
Console.WriteLine(logs.Pop());
Console.WriteLine($"count {logs.Count}");