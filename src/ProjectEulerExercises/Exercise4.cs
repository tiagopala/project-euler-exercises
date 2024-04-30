namespace ProjectEulerExercises;

internal static class ExerciseFour
{
    private static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();

        int lenght = numberString.Length;

        if (lenght % 2 != 0)
        {
            return false;
        }

        string firstPart = numberString.Substring(0, lenght/2);

        string secondPart = numberString.Substring(firstPart.Length);

        char[] invertedSecondPart = secondPart.Reverse().ToArray();

        for (int i = 0; i < firstPart.Length; i++)
        {
            if (firstPart[i] != invertedSecondPart[i])
            {
                return false;
            }
        }

        return true;
    }

    private static int GetLargestPalindromeFromDigit(int digitQuantity)
    {
        int minRange = (int)Math.Pow(10, digitQuantity - 1);
        int maxRange = (int)Math.Pow(10, digitQuantity) - 1;

        int largestValue = 0;

        for (int i = minRange; i <= maxRange; i++)
        {
            for (int j = minRange; j <= maxRange; j++)
            {
                int product = i * j;

                if (IsPalindrome(product) && product > largestValue)
                {
                    largestValue = i * j;
                }
            }
        }

        return largestValue;
    }

    public static void GetLargestPalindromeProduct()
    {
        var result = GetLargestPalindromeFromDigit(3);

        Console.WriteLine(result);
    }
}
