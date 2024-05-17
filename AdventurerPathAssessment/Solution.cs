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

                double yAxis = stepsDict['F'] - stepsDict['B'];
                double xAxis = stepsDict['R'] - stepsDict['L'];

                double totalDistance = Math.Sqrt((yAxis * yAxis) + (xAxis * xAxis));

                return totalDistance;
            }
            catch
            {
                throw new FormatException("Directions formatted incorrectly, cannot parse.");
            }
        }
    }
}
