using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        static string _fizz = "Fizz";
        static string _buzz  = "Buzz";

        public static string FizzBuzz(float number)
        {
            if (DivisableByThree(number) && DivisableByFive(number))
                return $"{_fizz}{_buzz}";

            if (DivisableByThree(number))
                return _fizz;

            if (DivisableByFive(number))
                return _buzz;

            return $"{number}";
        }

        private static bool DivisableByThree(float number)
        {
            return (number % 3) == 0;
        }

        private static bool DivisableByFive(float number)
        {
            return (number % 5) == 0;
        }
    }
}
