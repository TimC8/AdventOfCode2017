using AdventOfCode2017.Day_1;
using AdventOfCode2017.Day2;
using AdventOfCode2017.Day3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 277678;
            SpiralMemorySolver solver = new SpiralMemorySolver(input);
            Console.WriteLine(solver.SolveManhattanDistance());
            Console.ReadLine();
        }
      
    }
}
