using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    internal class _5
    {
        public static void age()
        {
            Console.WriteLine("Enter the age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 21)
            {
                Console.WriteLine("You are eligible.");
            }
            else
            {
                Console.WriteLine("You are not eligible.");
            }
        }
    }
}
