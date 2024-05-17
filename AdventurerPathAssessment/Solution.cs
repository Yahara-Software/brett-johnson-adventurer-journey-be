using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventurerPathAssessment
{
    internal class Solution
    {
        public static double FindSteps(string directions)
        {
            char[] splitters = ['F', 'B', 'R', 'L'];
            try
            {
                double[] stepCounts = directions.Split(splitters, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();

                Dictionary<char, double> stepsDict = splitters.ToDictionary(c => c, c => 0.0);

                int index = 0;
                foreach (char character in directions)
                {
                    if (splitters.Contains(character))
                    {
                        stepsDict[character] += stepCounts[index];
                        index++;
                    }
                }

                return CalculateSteps(stepsDict);
            }
            catch
            {
                throw new FormatException("Directions formatted incorrectly, cannot parse.");
            }
        }

        private static double CalculateSteps(Dictionary<char, double> dictionary)
        {
            double yAxis = dictionary['F'] - dictionary['B'];
            double xAxis = dictionary['R'] - dictionary['L'];

            double totalDistance = Math.Sqrt((yAxis * yAxis) + (xAxis * xAxis));

            return totalDistance;
        }
    }
}
