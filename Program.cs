//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace GenericTestMaximumNumber
{

    public class Program
    {
        public static void Main(string[] args)
        {
           
            RefactorCodeMaxNum obj1 = new RefactorCodeMaxNum();

            int result=obj1.MaxNum<int>(21,33,44);

            Console.WriteLine(result);


//----------------------------------------------------------------------------------------------//
           //UsingGenericMaxNumber<int> obj = new UsingGenericMaxNumber<int>();
            //obj.GenericMaxNumber(firstValue,secondvalue,thirdValue);


            //    double firstValue = 23.45;
            //    double secondvalue = 12.32;
            //    double thirdValue = 23.44;


            //MaximumFloatNumber.fMaximumNumber(firstValue, secondvalue, thirdValue);
            //Console.WriteLine(MaximumFloatNumber.fMaximumNumber(firstValue, secondvalue, thirdValue));

            //string firstValue = "shweta";
            //string secondvalue = "Prithvi";
            //string thirdValue = "Hrishikesh";
            //MaximumString.Maximumstring(firstValue, secondvalue, thirdValue);
            //    Console.WriteLine(MaximumString.Maximumstring(firstValue, secondvalue, thirdValue));

        }
    } 
}