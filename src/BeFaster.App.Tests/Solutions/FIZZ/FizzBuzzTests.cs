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
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(21, ExpectedResult = "fizz")]
        [TestCase(22, ExpectedResult = "deluxe")]
        [TestCase(83, ExpectedResult = "fizz")]
        public string DivisableByThreeReturnsFizzOtherwiseNumber(int number)
        {
            var result = FizzBuzzSolution.FizzBuzz(number);

            return result;
        }

        [TestCase(5, ExpectedResult = "buzz")]
        [TestCase(10, ExpectedResult = "buzz")]
        [TestCase(50, ExpectedResult = "buzz")]
        [TestCase(53, ExpectedResult = "fizz buzz")]
        [TestCase(2, ExpectedResult = "2")]
        public string DivisableByFiveReturnsFizzOtherwiseNumber(int number)
        {
            var result = FizzBuzzSolution.FizzBuzz(number);

            return result;
        }

        [TestCase(15, ExpectedResult = "fizz buzz")]
        [TestCase(30, ExpectedResult = "fizz buzz")]
        [TestCase(45, ExpectedResult = "fizz buzz")]
        [TestCase(41, ExpectedResult = "41")]
        public string DivisableByThreeAndFiveReturnsFizzOtherwiseNumber(int number)
        {
            var result = FizzBuzzSolution.FizzBuzz(number);

            return result;
        }

        [TestCase(33, ExpectedResult = "fizz fake deluxe")]
        [TestCase(222, ExpectedResult = "fizz deluxe")]
        [TestCase(777, ExpectedResult = "fizz fake deluxe")]
        [TestCase(41, ExpectedResult = "41")]
        public string Delux(int number)
        {
            var result = FizzBuzzSolution.FizzBuzz(number);

            return result;
        }

        [TestCase(22, ExpectedResult = "deluxe")]
        [TestCase(333, ExpectedResult = "fizz fake deluxe")]
        [TestCase(555, ExpectedResult = "fizz buzz fake deluxe")]
        [TestCase(41, ExpectedResult = "41")]
        public string FizzBuzzDelux(int number)
        {
            var result = FizzBuzzSolution.FizzBuzz(number);

            return result;
        }

    }
}

