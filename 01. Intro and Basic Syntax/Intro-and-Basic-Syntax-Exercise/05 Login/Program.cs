using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";
            int endLoop = username.Length - 1;
            for (int i = endLoop; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();
            int counter = 0;
            while (input != password)
            {
                
                counter++;
                if (counter > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }   
    }
}
