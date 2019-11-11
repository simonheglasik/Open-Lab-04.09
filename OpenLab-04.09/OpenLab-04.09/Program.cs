using System.Collections.Generic;
using System;
namespace OpenLab_04._09
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Class1();
            List<string> list = new List<string> { "slovo", "slovo", "paprika", "Jozo", "paprika", "slovo" };
            var lo = a.RemoveDups(list);
            foreach (string s in lo) Console.WriteLine(s);
        }
    }
}