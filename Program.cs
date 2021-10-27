using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Test_Maximum
{
    class Program { 
 
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 9, 5, 6 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintingMaxValue();

            Console.ReadLine();
        }
    }
}
