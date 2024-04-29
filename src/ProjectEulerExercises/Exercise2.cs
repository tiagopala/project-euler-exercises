namespace ProjectEulerExercises;

internal class ExerciseTwo
{
    public static IEnumerable<int> GetFibonacciNumbers(int maxRange)
    {
        List<int> fibonacciNumbers = new();

        for (int i = 1; i <= maxRange; i++)
        {
            if (i == 1 || i == 2)
            {
                fibonacciNumbers.Add(i);

                continue;
            }

            int next = fibonacciNumbers[i - 2] + fibonacciNumbers[i - 3];

            if (next > maxRange)
            {
                break;
            }

            fibonacciNumbers.Add(next);
        }

        return fibonacciNumbers;
    }

    public static int SumEvenTerms(IEnumerable<int> terms)
    {
        int sum = 0;

        List<int> termsList = terms.ToList();

        for (int i = 0; i < termsList.Count; i++)
        {
            if (termsList[i] % 2 == 0)
            {
                sum += termsList[i];
            }
        }

        return sum;
    }

    public static void SumEvenFibonacciNumbers()
    {
        IEnumerable<int> fibonacciNumbers;

        fibonacciNumbers = GetFibonacciNumbers(4000000);

        int result = SumEvenTerms(fibonacciNumbers);

        Console.WriteLine($"\nExercise 2 response = " + result);
    }
}
