using System;

namespace myVar_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double myVar = 7;

            // Process
            Console.WriteLine(-1 + 4 * myVar);
            Console.WriteLine((35 + 5) % myVar);
            Console.WriteLine(14 + -4 * 6 / 12);
            Console.WriteLine(2 + 12 / 6 * 1 - myVar % 2);

            //Output
            if (myVar * myVar < 10)
            {
                Console.WriteLine("\nmyVar is less than 4");
            }
            else
            {
                Console.WriteLine("\nmyVar is greater than 4");
            }
        }
    }
}
