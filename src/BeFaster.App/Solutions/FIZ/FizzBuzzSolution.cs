using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        static string _fizz = "Fizz";
        static string _buzz  = "Buzz";

        public static string FizzBuzz(float number)
        {
            if ()
                return _fizz;

            if (number % 5 == 0)
                return _buzz;

            return $"{number}";
        }

        private static bool DivisableByThree(float number)
        {
            return (number % 3) == 0;
        }
    }
}



