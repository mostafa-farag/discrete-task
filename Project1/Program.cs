using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, flag, n1, n2;
            Console.WriteLine("enter range i.e n1 and n2 ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            num = n1;
            while (num<=n2)
            {


                flag = 0;
                for ( i = 2; i <num ; i++)
                {
                   
                    
                    if (num%i==0)
                    {
                        flag = 1;
                        break;

                    }


                }

                if (flag==0)
                {
                    Console.WriteLine("number:" + num);
                    num++;
                }

            }
        }
    }
}
