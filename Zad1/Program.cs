using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new String_Filter();

            var input = Console.ReadLine();

            instance.Display_Results(input);

            Console.ReadLine();
        }
    }
}
