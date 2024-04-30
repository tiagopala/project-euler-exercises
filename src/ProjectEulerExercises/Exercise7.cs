namespace ProjectEulerExercises;

internal class ExerciseSeven
{
    // implement function to verify if is a prime number

    // implement a function to check the position of a prime number

    private static bool IsPrimeNumber(int number)
    {
        int timesDivisible = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                timesDivisible++;
        }

        if (timesDivisible > 2)
            return false;

        return true;
    }

    private static int GetPrimeNumberAtPosition(int number)
    {
        int primeNumbersQuantity = 0;
        int actualNumber = 2;

        while (true)
        {
            if (IsPrimeNumber(actualNumber))
                primeNumbersQuantity++;

            if (primeNumbersQuantity == number)
                break;

            actualNumber++;
        }

        return actualNumber;
    }

    public static void Get10001stPrime()
    {
        var result = GetPrimeNumberAtPosition(10001);

        Console.WriteLine("Exercise 7 response = " + result);
    }
}
