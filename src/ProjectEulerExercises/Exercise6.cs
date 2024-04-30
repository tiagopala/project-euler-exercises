namespace ProjectEulerExercises;

internal class ExerciseSix
{
    // implement function to calculate sum of squares from a range

    // implement function to calculate the square of the sum from a range

    // calculate the difference between the results

    private static int CalculateSumOfSquares(int minRange, int maxRange)
    {
        int sum = 0;

        for (int i = minRange; i <= maxRange; i++)
        {
            sum += (int)Math.Pow(i, 2);
        }

        return sum;
    }

    private static int CalculateSquareOfSum(int minRange, int maxRange)
    {
        int sum = 0;

        for(int i = minRange;i <= maxRange; i++)
        {
            sum += i;
        }

        return (int)Math.Pow(sum,2);
    }

    public static void SumSquareDifference()
    {
        int minRange = 1;
        int maxRange = 1000;

        int resultSumOfSquares = CalculateSumOfSquares(minRange, maxRange);

        Console.WriteLine(resultSumOfSquares);

        int resultSquareOfSum = CalculateSquareOfSum(minRange, maxRange);

        Console.WriteLine(resultSquareOfSum);

        int result = resultSquareOfSum - resultSumOfSquares;

        Console.WriteLine("Exercise 6 Response = " + result);
    }
}
