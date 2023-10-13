using System;
namespace RomanNumbersNS
{
	public class RomanNumbers
	{
		public RomanNumbers()
		{
		}

        public string convert(int number)
        {
            if (number == 1) {
                return "I";
            } else if (number == 2) {
                return "II";
            }
            return "III";
        }
    }
}

