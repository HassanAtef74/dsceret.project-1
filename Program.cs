using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disceret.project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a n2");
            int n2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int x = n1; x <= n2; x++)
            {
                sum = 0;

                for (int i = 2; i <= x / 2; i++)
                {
                    if (x % i == 0)
                        sum += i;
                }
                if (sum == x)
                    Console.WriteLine(x);
            }
        }
    }
}