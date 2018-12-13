using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car
    {
        private string Make;
        private string Model;
        private int Year;
        public int Speed;
        

        public Car(string pMake, string pModel, int pYear, int pSpeed)
        {
            this.Make = pMake;
            this.Model = pModel;
            this.Year = pYear;
            this.Speed = pSpeed;
        }

        public Car(string pMake, string pModel, int pYear)
        {
            this.Make = pMake;
            this.Model = pModel;
            this.Year = pYear;
            this.Speed = 0;
            
        }

        public int SpeedUp()
        {
            this.Speed++;
            return this.Speed;


        }

         public int SlowDown()
        { 
            if(this.Speed > 0)
            {
                this.Speed--;
            }

            return this.Speed;


        }

        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + "is going" + Speed + "MPH");
                                
        }

    }
}