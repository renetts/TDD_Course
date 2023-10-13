using System;
namespace FizzBuzz
{
	public class FizzBuzzClass
	{
		public FizzBuzzClass()
		{
		}

        public string[]? fizzBuzz(int number)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= number; i++)
            {
                string value = i.ToString();
                if (i % 3 == 0 && i % 5 == 0)
                {
                    value = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    value = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    value = "Buzz";
                }
                result.Add(value);
            }
            return result.ToArray();
        }
    }
}

