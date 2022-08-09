//declare delegate
public delegate int DelegateSquare(int num1 ,int num2);
public delegate void DelegateSquare(int num1, int num2);
class Program {


    static void Main() {
        DelegateSquare dsI = new DelegateSquare(Square);
        int result = dsI(2,2);
        Console.WriteLine(result);

        DelegateSquare dsV = new DelegateSquare(Square1);
        var result1 = dsV(2,2);
        Console.WriteLine(result1);
    }
    public static int Square(int num1,int num2 )
    {
        return num1 * num2;
    }

    public static void Square1(int num1, int num2)
    {
        int res = num1 * num2;
        Console.WriteLine(res);
    }
}