using System;

namespace FloydTriangle
{
    class FloydTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows you want in Floyd Triangle");
            int rows = int.Parse(Console.ReadLine());

            int numberToPrint = 0;
            for(var i=0; i< rows; i++)
            {
                for (var j = 0; j <= i; j++)
                    Console.Write(++numberToPrint + " ");
                Console.WriteLine();
            }
        }
    }
}