using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Day_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day_1.Tests
{
    [TestClass()]
    public class CaptchaSolverTests
    {
        [TestMethod()]
        public void SolveCaptchaPartOneTest()
        {
            CaptchaSolver solver = new CaptchaSolver("91212129");
            int solution = solver.SolveCaptcha(1);
            Assert.AreEqual(9, solution);
        }

        [TestMethod()]
        public void SolveCaptchaPartTwoTest()
        {
            CaptchaSolver solver = new CaptchaSolver("12131415");
            int solution = solver.SolveCaptcha(4);
            Assert.AreEqual(4, solution);
        }
    }
}