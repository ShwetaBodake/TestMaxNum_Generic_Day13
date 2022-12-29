//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static GenericTestMaximumNumber.Program;

namespace GenericTestMaximumNumber
{

    public class Program
    {
        public static void Main(string[] args)
        {

            int[] array = { 122, 566, 344, 894, 456 };
            PrintmaxMethod<int> generic = new PrintmaxMethod<int>(array);
            generic.PrintmaxValue();
        }

        public class PrintmaxMethod<T> where T : IComparable
        {
            public T[] value;

            public PrintmaxMethod(T[] value)
            {
                this.value = value;
            }

            public T[] Sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }

            public T MaxValue(params T[] values)
            {
                var sorted_values = Sort(values);
                return sorted_values[^1];
            }

            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return max;
            }

            public void PrintmaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum value is :" + max);
            }

        }
    }

}
    
