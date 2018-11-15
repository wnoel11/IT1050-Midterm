using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            int i = 10;
            Boolean keepLooping = true;
            while (keepLooping)
            { if (i <= 9) keepLooping = false; i++; Console.WriteLine(i); }

            //#2

            int z = 2;

            while (z <= 129)
            {
                Console.WriteLine("[{0}]", z);

                z = z + 2;
            }

            Console.ReadLine();

            //#3

            for (int y = 49; y >= 1; y--)
            {
                Console.Write(y);
                if (y > 1)
                {
                    Console.Write(",");
                }

            }

            Console.ReadLine();

            //#4

            int x = 1;
            while (x < 22)
            {
                Console.Write(x);
                x = x + 2;

                if (x < 22)
                {
                    Console.Write("   ");
                }
            }
            Console.ReadLine();

            //#5
            int n = 8;
            int j = 10;
            while (j < n)
            {
                Console.Write("*");
                j++;
            }

            //The do-while loop will run at least while checking if the condition is true. A do-while loop
            //would print a "*" even though the statement condition is not true, 10 is not less than 8.
            //The while loop will check if the condition is true of false before running. A while loop
            //would not print a "*" because 10 is not less than 8. 

            Console.ReadLine();

            //#6

            bool icyRain = false;
            bool tornadoWarning = false;

            if (icyRain == false || tornadoWarning == false)

            {
                Console.WriteLine("Let's go outside!");
            }

        }
    }
}
