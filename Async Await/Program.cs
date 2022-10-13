class program {
  public static void Main(string[] args)
    {
        CallAllMethods();
        Console.ReadLine();
    }
   public static async void CallAllMethods()
    {
        var letCompleteMethod1 = await Method1();
        var letCompleteMethod2 = await Method3();
        Method2();
        
    }

    static async Task<bool> Method1()
    {
        bool result = false;
        await Task.Run(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("method 1");
            result = true;
        });
        return result;
    } 
    static async void Method2()
    {
        await Task.Run(() =>
        {
            Thread.Sleep(5000);
            Console.WriteLine("method 2");
        });
    }
    static async Task<bool> Method3()
    {
        bool result = false;
        await Task.Run(() =>
        {
            Thread.Sleep(5000);
            Console.WriteLine("method 3");
            result = true;
        });
        return result;
    }

    
}