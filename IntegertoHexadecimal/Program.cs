using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegertoHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 15;

            string Hexvalue =
                Convert.ToString(value, 16).PadLeft(2, '0').ToUpper();

            Console.WriteLine("Value in Decimal {0}", value);
            Console.WriteLine("Value in Hexadecimal {0}", Hexvalue);

            Console.ReadLine();
        }
    }
}
