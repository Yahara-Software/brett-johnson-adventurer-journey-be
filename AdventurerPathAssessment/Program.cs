namespace AdventurerPathAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalDistance = Solution.FindSteps("15F6B6B5L16R8B16F20L6F13F11R");
            Console.WriteLine($"Euclidean distance is {totalDistance} steps.");
        }
    }
}
