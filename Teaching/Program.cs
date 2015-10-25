using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter your age");
			int userAge = Convert.ToInt32(Console.ReadLine());

			if (userAge < 21)
			{
				Console.WriteLine("You must be at least 21 to enter this bar");
			}
			else if (userAge == 21)
			{
				Console.WriteLine("You are barely old enough to enter the bar");
			}
			else
			{
				Console.WriteLine("Welcome to the bar");
			}
			Console.ReadLine();
        }
    }
}
