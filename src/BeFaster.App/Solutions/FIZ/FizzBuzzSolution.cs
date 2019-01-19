using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        static const string _fizz = "Fizz";

        public static string FizzBuzz(float number)
        {
            if (number % 3 == 0)
                return _fizz;

            return $"{number}";
        }
    }
}

