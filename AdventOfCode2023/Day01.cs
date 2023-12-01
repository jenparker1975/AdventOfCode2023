using System.Text.RegularExpressions;

namespace AdventOfCode2023
{
    internal class Day01
    {
        public int SolvePartOne()
        {
            return solveProblem(true);
        }

        public int SolvePartTwo()
        {
            return solveProblem(false);
        }

        private int solveProblem(bool part1)
        {
            var replacements = getReplacements(part1);
            string[] lines = File.ReadAllLines("Day01numbers.txt");
            string matcher = string.Join('|', replacements.Keys);
            int sum = 0;               
            foreach (string line in lines)
            {
                string first = Regex.Match(line, matcher).Value;
                var last = Regex.Match(line, matcher, RegexOptions.RightToLeft).Value;
                sum += int.Parse(replacements[first] + replacements[last]);
            }

            return sum;
        }


        private Dictionary<string, string> getReplacements(bool part1)
        {
            if (part1)
            {
                return new Dictionary<string, string>
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" },
                    { "4", "4" },
                    { "5", "5" },
                    { "6", "6" },
                    { "7", "7" },
                    { "8", "8" },
                    { "9", "9" }                 
                };
            }


            return new Dictionary<string, string>
            {
                { "1", "1" },
                { "2", "2" },
                { "3", "3" },
                { "4", "4" },
                { "5", "5" },
                { "6", "6" },
                { "7", "7" },
                { "8", "8" },
                { "9", "9" },
                { "one", "1" },
                { "two", "2" },
                { "three", "3" },
                { "four", "4" },
                { "five", "5" },
                { "six", "6" },
                { "seven", "7" },
                { "eight", "8" },
                { "nine", "9" },
            };
        }
    }
}
