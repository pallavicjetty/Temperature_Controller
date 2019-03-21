using System;
using System.Collections.Generic;
using System.IO;

namespace Temperature_controller
{
    public delegate void temp(int threshold);
    public class Random_generation
    {
        event temp MyEvent;
        public int max;
        public int min;

        public char RandomTemp { get; private set; }

        public void GetRandomNumbers(int min1, int max1)
        {
            for (int RandomIndex = 0; RandomIndex < 10; RandomIndex++)
            {
                Random random = new Random();
                int RandomTemp = random.Next(min1 - 6, max1 + 6);
                Console.WriteLine("\nThe Temperature is {0} degree celsius ", RandomTemp);
                DateAndTime();



                if (RandomTemp <= min1|| RandomTemp >= max1)
                {
                    TemperatureManager(RandomTemp);
                }
                else
                {
                    Console.WriteLine("Temperature is normal");
                }
                Console.ReadKey();
            }

        }
        public void TemperatureManager(int Temperature)
        {
                //call delegate method before going to print
                if (MyEvent != null)
                MyEvent(Temperature);
            Console.WriteLine("Temperature crossed the threshold limit which is equal to {0}\n", Temperature);
            DateAndTime();
        }
        public void DateAndTime()
        {

            string label1 = DateTime.Now.ToLongTimeString();//for current date
            string label2 = DateTime.Now.ToLongDateString();//for current time
            Console.WriteLine("date is {0}", label2);
            Console.WriteLine("time is {0}", label1);
            
        }
       
        
    }

}


       








