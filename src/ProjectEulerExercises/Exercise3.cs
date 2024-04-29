namespace ProjectEulerExercises;

internal static class ExerciseThree
{
    // Prime Factors are numbers that can be divided only by 1 and by the them.
    // Example: 17 can be divided only by 1 and by 17.

    public static List<long> GetPrimeFactors(long number, List<long>? primeFactors = null)
    {
        primeFactors ??= new();

        for (long i = 2; i <= number; i++)
        {
            if (number % i == 0)
            {
                primeFactors.Add(i);

                long remainder = number / i;

                if (remainder != 1)
                {
                    GetPrimeFactors(remainder, primeFactors);
                }

                break;
            }
        }

        return primeFactors;
    }

    public static void CalculateLargestPrimeFactor()
    {
        var primeFactors = GetPrimeFactors(600851475143);

        var result = primeFactors.Last();

        Console.WriteLine($"\nExercise 3 response = " + result);
    }
}
