using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionExOne.Abstract;

namespace FunctionExOne
{
    public class FunctionExOne1 : IExercise
    {
        public int GetLastDigit(int number)
        {
            return number % 10;
        }

        public int GetAllButLastDigit(int number)
        {
            int number_minus_last_digit = number - GetLastDigit(number);
            return number_minus_last_digit / 10;
        }

        public int GetAmountOfDigits(int number)
        {
            return number.ToString().Length;
        }

        public int GetDigintInIndex(int number, int index)
        {
            char char_in_index = number.ToString()[index];
            return int.Parse(char_in_index.ToString());
        }
    }
}
