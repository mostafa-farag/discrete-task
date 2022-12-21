using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static bool isperfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number;i++ )
            {
                if (number%i==0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                return true;
            }
            return false;
            
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("please enter the first number");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the second number");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (int i = x; i <= y; i++)
            {
                if (isperfect(i)) Console.WriteLine("{0},", i); 
               
            }
            Console.ReadKey();
        }
        
    }
}
