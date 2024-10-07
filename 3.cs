using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PRAC
{
    internal class StringDemo
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int s2=int.Parse(Console.ReadLine());
            int rev=0, d=0, sum=0;
            for(int i=s2; i>0; i=i/10)
            {
                d = i % 10;
                rev = rev * 10 + d;
                sum += d;
            }
            Console.WriteLine(rev+" "+sum);

        }
    }
}
