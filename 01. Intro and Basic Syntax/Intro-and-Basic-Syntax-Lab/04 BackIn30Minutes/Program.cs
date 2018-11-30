using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalminutes = hours * 60 + minutes + 30;

            int newHours = 0;
            int newMinutes = 0;

            if (totalminutes < 60)
            {
                Console.WriteLine($"0:{totalminutes:D2}");
            }
            else
            {
                newHours = totalminutes / 60;
                newMinutes = totalminutes % 60;

                if (newHours > 23)
                {
                    newHours = newHours - 24;
                }
                
            }
            Console.WriteLine($"{newHours}:{newMinutes:D2}");
        }
    }
}
