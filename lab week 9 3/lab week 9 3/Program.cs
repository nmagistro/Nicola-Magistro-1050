using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_week_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            myMath iMyMath = new myMath();



            iMyMath.Multiply(12,24);
            Console.WriteLine("The result for multiplication is: " + iMyMath.GetResult());

            iMyMath.Divide(15, 30);
            Console.WriteLine("The result of division is:" + iMyMath.GetResult());

            iMyMath.Subtract(30, 20);
            Console.WriteLine("The result of subtraction is:" + iMyMath.GetResult());

            iMyMath.Add(200, 300);
            Console.WriteLine("The result of addition is:" + iMyMath.GetResult());


        }
    }
}
