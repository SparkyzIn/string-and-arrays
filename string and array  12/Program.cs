using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace string_and_array__12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your first name");

            string firstname = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            string lastname = Console.ReadLine();
            string name = string.Concat(firstname, lastname);
            Console.WriteLine("your name is " + name);
            string[] cars;
            cars = new string[8];
            cars[0] = "saleem";
            Console.WriteLine("array name is " + cars[0]);
            cars[1] = "salman";
            Console.WriteLine("array name is " + cars[1]);
            Console.ReadLine();
            #region
            string command = "";
            do
            {
                Console.WriteLine("enter any command");
                Console.ReadLine();
                Console.WriteLine("Executing Command...");

            } while (command != "Exit");

            #endregion





            

        }
    }
}
