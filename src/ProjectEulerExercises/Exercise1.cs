namespace ProjectEulerExercises;

internal static class ExerciseOne
{
    private static IEnumerable<int> GetMultiples(int multiple, int range)
    {
        var multiples = new List<int>();

        for (int actualNumber = 1; actualNumber < range; actualNumber++)
        {
            if (actualNumber % multiple == 0)
            {
                multiples.Add(actualNumber);
            }
        }

        return multiples;
    }

    private static int SumNumbers(IEnumerable<int> sequence)
    {
        int sum = 0;

        List<int> list = sequence.ToList();

        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }

        return sum;
    }

    public static void CalculateMultiplesOf3And5At1000Range()
    {
        var multiplesForThree = GetMultiples(3, 1000);

        var multiplesForFive = GetMultiples(5, 1000);

        var combinedList = new List<int>(multiplesForThree);

        combinedList.AddRange(multiplesForFive);

        var combinedDistinctList = combinedList.Distinct();

        var result = SumNumbers(combinedDistinctList);

        Console.WriteLine($"\nExercise 1 response = " + result);
    }
}
