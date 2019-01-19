using BeFaster.App.Solutions.HLO;
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
        [Test]
        public string SayHello()
        {
            var result = HelloSolution.Hello("jim");

            Assert.Equals("hello jim", result);

            return result;
        }
    }
}
