using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        static string _fizz = "Fizz";
        static string _buzz  = "Buzz";

        public static string FizzBuzz(float number)
        {
            if (number % 3 == 0)
                return _fizz;

            if (number % 5 == 0)
                return _buzz;

            return $"{number}";
        }
    }
}


