using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2017.Day3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.Day3.Tests
{
    [TestClass()]
    public class SpiralMemorySolverTests
    {
        [TestMethod()]
        public void SolveManhattanZeroDistanceTest()
        {
            SpiralMemorySolver solver = new SpiralMemorySolver(1);
            Assert.AreEqual(0, solver.SolveManhattanDistance());
        }

        [TestMethod()]
        public void SolveManhattanCornerDistanceTest()
        {
            SpiralMemorySolver solver = new SpiralMemorySolver(17);
            Assert.AreEqual(4, solver.SolveManhattanDistance());
        }

        [TestMethod()]
        public void SolveManhattanEdgeDistanceTest()
        {
            SpiralMemorySolver solver = new SpiralMemorySolver(18);
            Assert.AreEqual(3, solver.SolveManhattanDistance());
        }
    }
}