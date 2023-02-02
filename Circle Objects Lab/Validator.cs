using System;
namespace Circle_Objects_Lab
{
	public class Validator
	{
		public static double GetUserNumber()
		{
			double result = 0;
			Console.WriteLine("Please enter a number.");

			while (!double.TryParse(Console.ReadLine(), out result) == false)
			{
				Console.WriteLine("Invalid Input. Try again.");
			}

			return result;
		}


		public static double GetNumberInRange(double min)
		{
			double result = double.MinValue;
			while (result <= min)
			{
				result = GetUserNumber();
				if (result <= min)
				{
					Console.WriteLine($"Number must be greater or equal to {min}");
				}
			}
			return result;
        }
        //overloaded
        public static bool GetContinue(string msg, string yes, string no)
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine($"{msg} {yes}/{no}");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == yes.ToLower().Trim())
                {
                    result = true;
                    break;
                }
                else if (choice == no.ToLower().Trim())
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return result;
        }
    }
	}
}

