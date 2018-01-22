using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat == true)
            {
                Console.WriteLine("To calculate the dimensions of a room");
                Console.WriteLine("Enter Length:");
                Double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                Double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Height:");
                Double height = Convert.ToDouble(Console.ReadLine());

                Double perimiter = length * 2 + width * 2;
                Double area = length * width;
                Double volume = length * width * height;

                Console.WriteLine("The perimiter of the room is: " + perimiter);
                Console.WriteLine("The area of the room is: " + area);
                Console.WriteLine("The volume of the room is: " + volume);

                Console.WriteLine("Would you like to run this program again? (Y or N)");
                var doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain != 'y' && doAgain != 'Y')
                {
                    repeat = false;
                }
            }
        }
    }
}
