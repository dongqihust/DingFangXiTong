using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "605  475 121 ,4123 12 #";
            string pattern = "(\\D+)|(\\W+)";
            foreach (string result in Regex.Split(input, pattern))
            {
                if (Regex.IsMatch(result, "^[0-9a-zA-Z]+$"))
                {
                    Console.WriteLine("'{0}'", result);
                }
                
            }
            Console.ReadKey();
        }
    }

    
}
