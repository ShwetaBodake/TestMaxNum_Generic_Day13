//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace GenericTestMaximumNumber
{

    public class Program
    {
        public static void Main(string[] args)
        {
            int firstValue = 22;
            int secondvalue = 33;
            int thirdValue = 22;

            int output = MaximumIntegerNumber.MaximumNumber(firstValue, secondvalue, thirdValue);
            Console.WriteLine("Maximum Integer Number is: " + output);


        }
    }
}