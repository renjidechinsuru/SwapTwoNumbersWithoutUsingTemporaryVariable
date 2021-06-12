using System;

namespace SwapTwoNumbersWithoutUsingTemporaryVariable
{
    class GFG
    {
        static public void Main()
        {
            int a = 10, b = 25;

            Console.WriteLine("Value of a is : " + a);
            Console.WriteLine("Value of b is : " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("New Value of a is : " + a);
            Console.WriteLine("New Value of b is : " + b);
            Console.ReadLine();





        }
    }
}
