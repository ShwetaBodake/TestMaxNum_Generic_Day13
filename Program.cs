//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace GenericTestMaximumNumber
{

    public class Program
    {
        public static void Main(string[] args)
        {


            GenericsMaximum<int> obj1 = new GenericsMaximum<int>(4, 3, 2);
            int result = obj1.Maximum();
            Console.WriteLine(result);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Maximum Number is:" + result);// To display Maximum Number
            Console.WriteLine("-----------------------------------");




            // GenericsMaximum obj = new GenericsMaximum();
            //    int[] array = { 122, 566, 344, 894, 456 };
            //    PrintmaxMethod<int> generic = new PrintmaxMethod<int>(array);
            //    generic.PrintmaxValue();
            //}

            //public class PrintmaxMethod<T> where T : IComparable
            //{
            //    public T[] value;

            //    public PrintmaxMethod(T[] value)
            //    {
            //        this.value = value;
            //    }

            //    public T[] Sort(T[] values)
            //    {
            //        Array.Sort(values);
            //        return values;
            //    }

            //    public T MaxValue(params T[] values)
            //    {
            //        var sorted_values = Sort(values);
            //        return sorted_values[^1];
            //    }

            //    public T MaxMethod()
            //    {
            //        var max = MaxValue(this.value);
            //        return max;
            //    }

            //    public void PrintmaxValue()
            //    {
            //        var max = MaxValue(this.value);
            //        Console.WriteLine("Maximum value is :" + max);
            //    }


            //bool check = true;
            //RefactorCodeMaxNum obj1 = new RefactorCodeMaxNum();

            //while(check)
            //{
            //    Console.WriteLine("SelectOption 1)Find Integer max number  2)Find Float max number 3)Find maximum string");

            //    int option = Convert.ToInt32(Console.ReadLine());

            //    switch(option)
            //    {
            //        case 1:
            //            int IntegerMaximum = obj1.MaxNum<int>(34, 22, 66);
            //            Console.WriteLine(IntegerMaximum);
            //            break;
            //        case 2:
            //            float FloatMaximum = obj1.MaxNum<float>(12.12f, 45.23f, 23.11f);
            //            break;
            //        case 3:
            //            string StringMaximum = obj1.MaxNum<string>("apple", "Banana", "Chickoo");
            //            Console.WriteLine(StringMaximum);
            //            break;
            //        default:
            //            check =!check;
            //            break;


            //    }
            //}

        }
    } 
}