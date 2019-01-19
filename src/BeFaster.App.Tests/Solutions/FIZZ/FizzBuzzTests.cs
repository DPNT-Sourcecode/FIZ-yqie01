using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.FIZZ
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(21, ExpectedResult = "Fizz")]
        [TestCase(22, ExpectedResult = "22")]
        public string DivisableByThreeReturnsFizzOtherwiseNumber(int number)
        {
            var result = FizzBuzzSolution.FizzBuzz(number);

            return result;
        }

    }
}

