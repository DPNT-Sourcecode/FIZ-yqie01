﻿using BeFaster.App.Solutions.HLO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]

    public class HelloSolutionTests
    {
        [TestCase("John", ExpectedResult = "Hello, John!")]
        public string SayHello(string name)
        {
            var result = HelloSolution.Hello(name);

            Assert.AreEqual("Hello, John!", result);

            return result;
        }
    }
}
