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
<<<<<<< HEAD
            int[] arr = { 1, 2, 3, 4, 9, 5, 6 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintingMaxValue();
=======
            //calling the generics method from main branch
           int value1= new GenericMaximum<int>(3,2,1).MaxMethod();
            double value2 = new GenericMaximum<double>(3.1, 2.5, 1.9).MaxMethod();
           string value3 = new GenericMaximum<string>("Apple","Peach","Banana").MaxMethod();


            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
>>>>>>> 0df17c0f359a5eedc4e81eac030627b3f06704bb
            Console.ReadLine();
        }
    }
}
