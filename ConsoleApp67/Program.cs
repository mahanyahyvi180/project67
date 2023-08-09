using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubnumber = cub(5);
            Console.WriteLine(cubnumber);
            Console.ReadLine();
        }

        static int cub(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
