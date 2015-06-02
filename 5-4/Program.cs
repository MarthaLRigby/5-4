using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, j = 25; ; i++, j--)
            {
                if (i > j)
                {
                    Console.WriteLine("Crossed over!");
                    break;
                }
                Console.WriteLine(i + " " + j);
            }
        }
    }
}
