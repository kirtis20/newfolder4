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
            Console.WriteLine("Enter the string: ");
            string s1=Console.ReadLine();
            bool b= s1.Contains("test");
            Console.WriteLine("contains: "+b);
            Console.WriteLine("Endswith: "+s1.EndsWith("t"));
            Console.WriteLine("Lower: "+s1.ToLower());
            Console.WriteLine("length: " + s1.Length);
            Console.WriteLine("equals: "+s1.Equals("test"));
            Console.WriteLine("Replace: "+s1.Replace('t','r'));
            Console.WriteLine("Split: "+s1.Split(s1));
            Console.WriteLine("Upper: "+s1.ToUpper());
            Console.WriteLine("Indexof: "+s1.IndexOf("t"));
            Console.WriteLine("last index: "+s1.LastIndexOf("t"));
        }
    }
}
