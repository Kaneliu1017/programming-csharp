// ============================================================
//  L07 · Classic loop algorithms
//  Topics: accumulator, min/max, counting, linear search,
//          running product (factorial), digit sum
// ============================================================
namespace LoopsPractice.Lessons;

public static class L07_LoopAlgorithms
{
    public static void Run()
    {
        Console.WriteLine("--- L07 · Loop algorithms ---");

        // TODO: compute factorial of n (n! = 1×2×3×…×n).
        //       Print 5! — expected: 120.
        int n = 5;
        Console.WriteLine($"{n}! = {Factorial(n)}");

        // TODO: find the min AND max of an int[] in one loop.
        int[] nums = [7, 2, 14, 1, 9, 5];
        (int min, int max) = MinMax(nums);
        Console.WriteLine($"Min: {min}  Max: {max}");

        // TODO: count how many words in a string[] have length > 4.
        string[] words = ["cat", "elephant", "dog", "hippopotamus", "bee"];
        Console.WriteLine($"Long words: {CountLong(words, 4)}");

        // TODO: compute the sum of digits of an integer.
        //       e.g. 1234 → 1+2+3+4 = 10
        //       Hint: n % 10 gives the last digit; n /= 10 removes it.
        Console.WriteLine($"Digit sum of 1234: {DigitSum(1234)}");

        // TODO: check if a number is prime.
        //       Loop from 2 to sqrt(n); break early if divisible.
        Console.WriteLine($"17 prime? {IsPrime(17)}");
        Console.WriteLine($"18 prime? {IsPrime(18)}");

        Console.WriteLine();
    }

    static int Factorial(int n)
    {
        // TODO: int result = 1; for loop multiplying; return result
        return 0;
    }

    static (int min, int max) MinMax(int[] arr)
    {
        // TODO: start min=arr[0], max=arr[0]; loop updating both
        return (0, 0);
    }

    static int CountLong(string[] words, int minLength)
    {
        // TODO: count words where word.Length > minLength
        return 0;
    }

    static int DigitSum(int n)
    {
        // TODO: sum = 0; while (n > 0) { sum += n%10; n /= 10; }
        return 0;
    }

    static bool IsPrime(int n)
    {
        // TODO: if n < 2 return false;
        //       for i from 2 to (int)Math.Sqrt(n);
        //       if n%i==0 return false; return true
        return false;
    }
}
