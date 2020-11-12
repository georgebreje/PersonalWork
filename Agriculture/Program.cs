using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose action.");
            string[] domain = { "Check", "Maintanance" , "", "Oils", "Meat", "Milk", "Eggs"};
            foreach(var aliment in domain)
                Console.WriteLine($"{aliment}");

        }
    }
}
