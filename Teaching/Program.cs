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
			// ignore this comment

			Console.WriteLine("Enter a number");
			int number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter another number");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("the sum of {0} and {1} is {2}", number, number2, AddNumbers(number, number2));
			Console.ReadLine();
        }

		static int AddNumbers(int firstNumber, int secondNumber)
		{
			int sum = firstNumber + secondNumber;
			return sum;
		}
    }
}
