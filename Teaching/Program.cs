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
            //penis
			AddNumbers(number, number2);
        }

		static int AddNumbers(int firstNumber, int secondNumber)
		{
			int sum = firstNumber + secondNumber;
			return sum;
		}
    }
}
