using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int i = 1;
            while (i <= 9)

            {
                Console.WriteLine(i);
                i = i + 2;
            }

            int startingValue;
            int limit;
            int incrementBy;

            while (true)

            {
                Console.WriteLine("Enter the starting value (or -1 to exit): ");
                startingValue = Convert.ToInt32(Console.ReadLine());
                if ((startingValue == 5) && (startingValue == 9))
                    break;
                Console.WriteLine("Enter the limit value: ");
                limit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the increment value: ");
                incrementBy = Convert.ToInt32(Console.ReadLine());
                for (int counter = startingValue; counter <= limit; counter = counter + incrementBy)
                {
                    Console.WriteLine(counter);
                }



            }
            */


            int i;
            i = 30;

            for (i = 30; i < 45; i++)
            {
                Console.WriteLine(i + 3);
                Console.WriteLine((i % 2) == 0); 
                
            }
        }
    


    }
}

