Xml file: 
<?xml version="1.0" encoding="utf-8" ?>
<Products>
	<Product>
		<pid>1</pid>
		<pname>delllaptop</pname>
		<price>80000</price>
		<dom>09-07-14</dom>
	</Product>
	<Product>
		<pid>2</pid>
		<pname>hplaptop</pname>
		<price>55000</price>
		<dom>10-07-14</dom>
	</Product>
	<Product>
		<pid>4</pid>
		<pname>acerlaptop</pname>
		<price>70000</price>
		<dom>12-07-14</dom>
	</Product>
</Products>


linqxml.cs:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Diagnostics;

namespace LinqProg
{
    class Linqxml
    {
        static void Main(string[] args)
        {
            XDocument pd= XDocument.Load("C:\\Users\\SXC\\source\\repos\\C#PRAC\\myfile.xml");
            var products = pd.Elements();
            Console.WriteLine("Display products price>400000:");
            //query 1
            var result = products.Elements("Product").Where(x=>(int)x.Element("price")>40000).Select(
                x => new {Name=x.Element("pname").Value,price=x.Element("price").Value,dom=x.Element("dom").Value});
            //new keyword compulsory is more than 1 is to be stored. datatype is internally managed.
            foreach( var item in result )
            {
                Console.WriteLine(item);
            }
            //query 2
            var result2 = products.Elements("Product").Select(
                x => new { Name = x.Element("pname").Value, price = x.Element("price").Value, dom = x.Element("dom").Value });

            foreach( var item in result2 )
            {
                Console.WriteLine(item);
            }
            //query 3 date>10-07-14
            Console.WriteLine("new query");
            var result3 = products.Elements("Product").Where(x => DateTime.ParseExact((string)x.Element("dom").Value, "dd-mm-yy", null) > DateTime.ParseExact("10-07-14", "dd-mm-yy", null)).Select(x => new
            {
                Name = x.Element("pname").Value,price = x.Element("price").Value,dom = x.Element("dom").Value
            });
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            //q4 display the name of products date>10-07-14
            Console.WriteLine("new query");
            var result4 = from x in products.Elements("Product") where DateTime.ParseExact((string)x.Element("dom"), "dd-mm-yy", null) > DateTime.ParseExact("10-07-14", "dd-mm-yy", null) let nm = (string)x.Element("pname") select nm;

            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }

            var v = from x in products.Elements("Product") where (int)x.Element("price") > 40000 select new { pname = (string)x.Element("pname"), (int)price = x.Element("price") };
            v.ToList().ForEach(x => Console.WriteLine(x.pname+" "+x.price));
        }
    }
}
