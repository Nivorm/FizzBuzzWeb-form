using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class NumberValidation : ValidationAttribute
	{
        private int firstVar = 3, secondVar = 5;
		public override bool IsValid(object? value)
		{
			if (value == null)
			{
				return true;
			}
			int number = (int)value;

			if (number % firstVar  == 0 && number % secondVar != 0)
			{
				ErrorMessage = "Fizz";
				return false;
			}
			else if (number % secondVar == 0 && number % firstVar != 0)
			{
				ErrorMessage = "Buzz";
				return false;
			}
			else if (number % firstVar == 0 && number % secondVar == 0)
			{
				ErrorMessage = "FizzBuzz";
				return false;
			}
			ErrorMessage = "Liczba " + number + " nie spelnia kryteriow FizzBuzz";
			return false;
		}
	}
}
