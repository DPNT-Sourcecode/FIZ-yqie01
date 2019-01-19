using System;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        static string _fizz = "fizz";
        static string _buzz  = "buzz";
        static string _deluxe = "deluxe";

        public static string FizzBuzz(float number)
        {
            if(NumberIsDelux(number))
                return _deluxe;

            if (DivisableByThreeContainsThree(number) && DivisableByFive(number))
                return $"{_fizz} {_buzz}";

            if (DivisableByThreeContainsThree(number))
                return _fizz;

            if (DivisableByFive(number))
                return _buzz;

            return $"{number}";
        }

        private static bool NumberIsDelux(float number)
        {
            bool result = true;

            if (number <= 10)
                return false;

            var firstDigit = $"{number}"[0];
            foreach (var item in $"{number}")
            {
                if(!item.Equals(firstDigit))
                {
                    result = false;
                }
            }
            return result;
        }

        private static bool DivisableByThreeContainsThree(float number)
        {
            bool result = false;

            if((number % 3) == 0)
            {
                result = true;
            }

            if ($"{number}".Contains("3"))
            {
                result = true;
            }

            return result;
        }

        private static bool DivisableByFive(float number)
        {
            bool result = false;

            if ((number % 5) == 0)
            {
                result = true;
            }

            if ($"{number}".Contains("5"))
            {
                result = true;
            }

            return result;
        }
    }
}




