using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "qwe123";
            string UserInput;
            int attempts = 5;

            

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Enter the password:");
                UserInput = Console.ReadLine();
                if (UserInput == password)
                {
                    Console.WriteLine("Password is correct. Accessed. ") ;
                    Console.ReadKey();
                    break;
                }

                else 
                {
                    Console.WriteLine("Password is not correct. Access denied. ");
                    Console.WriteLine($"Attempts left: {attempts - 1 - i}");     
                    Console.WriteLine();
                }
            }        
        }
    }
}