using System;
using System.Collections.Generic;
using System.Text;

namespace Movies
{
    public class Class1
    {

        public static List<string> GenerateNames()
        {
            List<string> names = new List<string>();
            names.Add("Gamma");
            names.Add("Beta");
            names.Add("Alpha");
            names.Add("Omega");
            return names;

        }
       public static void PrintNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name); 
            }
        }
    }
}
