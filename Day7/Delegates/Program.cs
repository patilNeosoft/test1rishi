
using Delegates;
class Program
{

    static void Main(string[] args)
    {
        Delg obj = new Delg();
        obj.Mainfunction(SecondMethod);


    }

private static void SecondMethod()
    {
       

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}
