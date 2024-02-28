using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Lab1_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 numbers of the Fibbonaci sequence:");
            int[] fibo = new int[10];
            fibo[0] = 0;
            fibo[1] = 1;
            for(int i = 2; i < 10; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            for( int i = 0; i < 10; i++)
            {
                Console.Write(fibo[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
