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

           int value1= new GenericMaximum<int>(3,2,1).MaxMethod();
            double value2 = new GenericMaximum<double>(3.1, 2.5, 1.9).MaxMethod();
           string value3 = new GenericMaximum<string>("Apple","Peach","Banana").MaxMethod();


            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.ReadLine();
        }
    }
}
