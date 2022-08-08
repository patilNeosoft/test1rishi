using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ExceptionExe
{
    internal class exceptionExe
    {
        public void Check(int[] myNumbers)
        {
            //try executing the code here
            try
            {
                Console.WriteLine(myNumbers[4]);

                }

            //if above code is not executing then pass this msg
            catch(Exception exe) 
            {
                Console.WriteLine("array size exceeded ! ");

            }

            //it will show regardless try or catch results 
            finally{
                Console.WriteLine("code execution has finished");
            }
        }

        //second method to use throw new
        public void CheckT(int num)
        {
            if (num > 10)
            {
                //if code is correct this will get printed on console
                Console.WriteLine("Correct value!");

            }
            else {
                //this will get printed in code itself
                throw new ArithmeticException("try with value less than 10");
            }
        }
        public const string pattern = @"^[+]?91[-\s]?[6-9][0-9]{9}$";
        public void MoValidation(string num) {
            if (!Regex.IsMatch(num, pattern)) {
                throw new InvalidMo("invalid mobile number.");
            }
        }
    }

}
