using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day2.Tests
{
    [TestClass()]
    public class CorruptionChecksumSolverTests
    {
        [TestMethod()]
        public void solveChecksumTest()
        {
            String input = @"5 1 9 5
7 5 3
2 4 6 8";
            CorruptionChecksumSolver solver = new CorruptionChecksumSolver(input);
            Assert.AreEqual(18, solver.solveChecksum());
        }

        [TestMethod()]
        public void solveChecksumPartTwoTest()
        {
            String input = @"5 9 2 8
9 4 7 3
3 8 6 5";
            CorruptionChecksumSolver solver = new CorruptionChecksumSolver(input);
            Assert.AreEqual(9, solver.solveDivisibleChecksum());
        }
    }
}