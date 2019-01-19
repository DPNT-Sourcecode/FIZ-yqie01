using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        static string _fizz = "fizz";
        static string _buzz  = "buzz";

        public static string FizzBuzz(float number)
        {
            if (DivisableByThreeContainsThree(number) && DivisableByFive(number))
                return $"{_fizz} {_buzz}";

            if (DivisableByThreeContainsThree(number))
                return _fizz;

            if (DivisableByFive(number))
                return _buzz;

            return $"{number}";
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




