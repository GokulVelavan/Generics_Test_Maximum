using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Test_Maximum
{
    public class GenericMaximum<T> where T:IComparable{
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value; //constructor 
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);// sorting values
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var Sorted_Values = Sort(values);
            return Sorted_Values[Sorted_Values.Length-1]; //during sorting the max value is passed to end of the array
                                                         //so passing the final element of the array
        }
       
        public void PrintingMaxValue()
        {
            var maximum = MaxValue(this.value);
            Console.WriteLine("The max of the values is : " + maximum);
        }
    }
}
