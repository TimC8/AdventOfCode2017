﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
Description:
Part 1
The spreadsheet consists of rows of apparently-random numbers.To make sure the recovery process is on the right track, they need you to calculate the spreadsheet's checksum. For each row, determine the difference between the largest value and the smallest value; the checksum is the sum of all of these differences.

For example, given the following spreadsheet:

5 1 9 5
7 5 3
2 4 6 8
The first row's largest and smallest values are 9 and 1, and their difference is 8.
The second row's largest and smallest values are 7 and 3, and their difference is 4.
The third row's difference is 6.
In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18

Part 2
It sounds like the goal is to find the only two numbers in each row where one evenly divides the other - that is, where the result of the division operation is a whole number. They would like you to find those numbers on each line, divide them, and add up each line's result.

For example, given the following spreadsheet:

5 9 2 8
9 4 7 3
3 8 6 5
In the first row, the only two numbers that evenly divide are 8 and 2; the result of this division is 4.
In the second row, the two numbers are 9 and 3; the result is 3.
In the third row, the result is 2.
In this example, the sum of the results would be 4 + 3 + 2 = 
*/
namespace AdventOfCode2017.Day2
{
    public class CorruptionChecksumSolver
    {
        String inputSpreadsheet { get; set; }
        List<List<short>> sortedNumLists { get; set; }

        public CorruptionChecksumSolver(string inputSpreadsheet)
        {
            this.inputSpreadsheet = inputSpreadsheet ?? throw new ArgumentNullException(nameof(inputSpreadsheet));
            sortedNumLists = new List<List<short>>();
        }

        public int solveChecksum()
        {
            int checksum = 0;
            SplitIntoSortedLists();
            sortedNumLists.ForEach(l => checksum += l.Last() - l.First());
            return checksum;
        }

        public int solveDivisibleChecksum()
        {
            int sum = 0;
            SplitIntoSortedLists();
            sortedNumLists.ForEach(l => sum += SumOfDivisors(l));
            return sum;
        }

        private void SplitIntoSortedLists()
        {

            var lines = Regex.Split(inputSpreadsheet, "\r\n|\r|\n");
            foreach (String line in lines)
            {
                string[] numStrings = line.Split(null);
                List<short> lineList = new List<short>();
                Array.ForEach(numStrings, n => lineList.Add(short.Parse(n)));
                sortedNumLists.Add(lineList);
            }
            sortedNumLists.ForEach(l => l.Sort());
        }

        private int SumOfDivisors(List<short> nums)
        {
            int sum = 0;
            for (int i = 1; i < nums.Count(); i++)
            {
                for (int ii = i - 1; ii >= 0; ii--)
                {
                    if (nums[i] % nums[ii] == 0)
                    {
                        sum += nums[i] / nums[ii];
                    }
                }
            }
            return sum;
        }
    }
}
