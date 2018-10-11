using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Nicola_Magistro
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dAmountx;
            decimal dAmounty;
            decimal dAmountz;
            decimal dResult;
            decimal dSum;
            //decimal dDifference; 
            Console.WriteLine("enter the amount for the first number:");
            dAmountx = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the amount for the second number:");
            dAmounty = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter the amount for the third number:");
            dAmountz = decimal.Parse(Console.ReadLine());
            dResult = (dAmountx + dAmounty) * (dAmountz + 10);
            //dAmountx = x;
            //dAmounty = y;
            //dAmountz = z;

            //display result 
            dResult = (dAmountx + dAmounty) * (dAmountz + 10);
            Console.WriteLine("the result of {0:C} + {1:C} * {2:C} {2:C} + is {3:C} ", dAmountx, dAmounty, dAmountz, dResult);

        }
    }
}
