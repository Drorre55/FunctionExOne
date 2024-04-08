using FunctionExOne;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionExOne1 MyFunctions = new FunctionExOne1();
            
            Console.WriteLine(MyFunctions.GetLastDigit(123));
            Console.WriteLine(MyFunctions.GetAllButLastDigit(1234));
            Console.WriteLine(MyFunctions.GetAmountOfDigits(1234));
            Console.WriteLine(MyFunctions.GetDigintInIndex(1234, 1));
        }
    }
}
