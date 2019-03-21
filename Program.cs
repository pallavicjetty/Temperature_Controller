using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_controller
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the maximum threshold value\n");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum threshold value\n");
            int min = int.Parse(Console.ReadLine());

            var random_generation = new Random_generation();//publisher
            random_generation.GetRandomNumbers(min,max);
            

        }
    }
    

}
