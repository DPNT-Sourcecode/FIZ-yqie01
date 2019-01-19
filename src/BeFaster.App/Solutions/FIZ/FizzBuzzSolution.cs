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
            return (number % 3) == 0;
        }

        private static bool DivisableByFive(float number)
        {
            return (number % 5) == 0;
        }
    }
}


