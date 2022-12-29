//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace GenericTestMaximumNumber
{

    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            RefactorCodeMaxNum obj1 = new RefactorCodeMaxNum();

            while(check)
            {
                Console.WriteLine("SelectOption 1)Find Integer max number  2)Find Float max number 3)Find maximum string");

                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        int IntegerMaximum = obj1.MaxNum<int>(34, 22, 66);
                        Console.WriteLine(IntegerMaximum);
                        break;
                    case 2:
                        float FloatMaximum = obj1.MaxNum<float>(12.12f, 45.23f, 23.11f);
                        break;
                    case 3:
                        string StringMaximum = obj1.MaxNum<string>("apple", "Banana", "Chickoo");
                        Console.WriteLine(StringMaximum);
                        break;
                    default:
                        check =!check;
                        break;


                }
            }
          
        }
    } 
}