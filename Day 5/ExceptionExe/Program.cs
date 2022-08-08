using ExceptionExe;
int[] myNumbers = { 10, 20, 30,40 };

exceptionExe obj1 = new exceptionExe();
obj1.Check(myNumbers);

exceptionExe obj2 = new exceptionExe();
obj2.CheckT(11);

exceptionExe obj3 = new exceptionExe();
try
{
    Console.WriteLine("enter mobile number");
    string str = Console.ReadLine(); ;
    obj3.MoValidation(str);
    Console.WriteLine("valid mobile number");
    
}
catch(InvalidMo ex) 
{
    Console.WriteLine(ex.Message);
}








