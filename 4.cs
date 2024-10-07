using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProg
{
    class Class2
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //(p=> p%2==0)=lambda expression
            IEnumerable<int> n = arr.Where(p=> p%2==0).Select(p=>p);
            foreach(var m in n)
            {
                Console.WriteLine(m);
            }
            int count=arr.Count(x=>x>5);
            int avg=(int)arr.Average(x=>x);
            int max=arr.Max(x=>x);
            Console.WriteLine("Count is: " + count);
            Console.WriteLine("Avg is: "+avg);
            Console.WriteLine("Max is: " + max);
            IEnumerable<int> maxim = (from a in arr select max).Take(1);
            foreach(var m in maxim)
            {
                Console.WriteLine("maximum is: " + m);
            }
            Console.ReadKey();
        }
    }
}
