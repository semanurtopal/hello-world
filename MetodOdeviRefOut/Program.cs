using System;

namespace MetodOdeviRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 25;
            int number2 = 40;
            Console.WriteLine(Add(ref number1, number2));

            int number3;
            int number4 = 23;
            Console.WriteLine(Add2(out number3, number4));
        }

        static int Add(ref int number1, int number2)
        {
            number1 = 44;
            return number1 + number2;
        }

        static int Add2(out int number3, int number4) 
        {
            number3 = 16;
            return number3 + number4;
        }
    }
}
