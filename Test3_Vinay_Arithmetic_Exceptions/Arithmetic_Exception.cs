using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3_Vinay_Arithmetic_Exceptions
{
    public class Arithmetic_Exception
    {
        public void DevisionOfTwoNumbers()
        {
            Console.WriteLine("---DevisionOfTwoNumbers---");
            try
            {
                int num1; int num2; int total;
                Console.WriteLine("Enter num1 value:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num2 value:");
                num2 = Convert.ToInt32(Console.ReadLine());
                total = num1 / num2; Console.WriteLine("the result is :" + total);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num2 Should not be Zero'0' ");
            }
        }
        public void SumOfTwoNumbers()
        {
            Console.WriteLine("---SumOfTwoNumbers---");
            try
            {
                int num1; int num2;
                Console.WriteLine("Enter num1 value:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num2 value:");
                num2 = Convert.ToInt32(Console.ReadLine());
                

                int total = num1 - num2 ;
                Console.WriteLine("the result is :" + total);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter Numbers to all Variables, like 1,2,3...");
            }
        }
        
    } 
}





