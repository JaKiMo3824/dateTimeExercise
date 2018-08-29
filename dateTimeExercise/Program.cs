using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is: " + DateTime.Now);
            Console.WriteLine("Please enter a number to represent hours.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime current = DateTime.Now;
            Console.WriteLine("The current date and time plus the number of hours you entered equals: {0} ", current.AddHours(userInput));
            Console.ReadLine();


        }
    }
}
