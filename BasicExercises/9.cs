using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    internal class _9
    {
        public static void  Coordinate()
        {
            int co1, co2;
            Console.WriteLine("Enter the coordinate 1 : ");
            co1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinate 2 : ");
            co2 = Convert.ToInt32(Console.ReadLine());

            if (co1 > 0 && co2 > 0)
                Console.WriteLine(" First quadrant ");
            else if (co1 < 0 && co2 > 0)
                Console.WriteLine(" Second quadrant ");
            else if (co1 < 0 && co2 < 0)
                Console.WriteLine(" Third quadrant ");
            else if( co1 > 0 && co2 < 0)
                Console.WriteLine(" Fourth quadrant ");
            else if( co1 ==0 && co2 == 0)
                Console.WriteLine(" At Origin ");
        }
    }
}
