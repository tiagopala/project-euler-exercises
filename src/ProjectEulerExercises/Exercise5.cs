namespace ProjectEulerExercises;

internal static class ExerciseFive
{
    // get minRange and maxRange as input

    // create function to check if the number could be divided with no remainder

    // create function to iterate through minRange and maxRange until all of them succeded

    public static bool CouldBeDividedWithoutRemainder(int dividend, int divisor)
    {
        if (dividend % divisor == 0)
        {
            return true;
        }

        return false;
    }

    public static int GetSmallestPositiveNumber(int minRange, int maxRange)
    {
        bool found = false;
        int actualNumber = 1;

        while (!found)
        {
            int timesDivided = 0;

            for (int i = minRange; i <= maxRange; i++)
            {
                bool divisionResult = CouldBeDividedWithoutRemainder(actualNumber, i);

                if (divisionResult)
                {
                    timesDivided++;
                }
            }

            if (timesDivided == maxRange)
            {
                found = true;
            }
            else
            {
                actualNumber++;
            }
        }

        return actualNumber;
    }

    public static void SmallestMultiple()
    {
        int result = GetSmallestPositiveNumber(1, 10);

        Console.WriteLine("Exercise 5 response = " + result);
    }
}
