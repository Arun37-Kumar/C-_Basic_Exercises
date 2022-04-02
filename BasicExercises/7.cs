using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    internal class _7
    {
        public static void height()
        {
            int heightInCentimeters;
            Console.WriteLine("Enter the Height : ");
            heightInCentimeters = Convert.ToInt32(Console.ReadLine());

            if (heightInCentimeters <= 135)
            {
                Console.WriteLine("Person is dwarf.");
            }
            else
            {
                Console.WriteLine("Person is tall.");
            }
        }
    }
}
