using System;
using static System.Console;
using System.Xml.Linq;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XDocument();
            string s1 = "hello";
            String s2 = "world";
            WriteLine($"{s1} {s2}");
        }
    }
}
