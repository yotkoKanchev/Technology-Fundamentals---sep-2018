using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09RefactorVolumeOfPiramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = 0;
            double width = 0;
            double heigth = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());
            double volume = (lenght * width * heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
