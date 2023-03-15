using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
          int num1 = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter another number");
          int num2 = Convert.ToInt32(Console.ReadLine());
          
          int sum = num1 + num2;
          
          
          Console.WriteLine("Total of sum: " +` sum);
          
          
          
        }
    }
}
