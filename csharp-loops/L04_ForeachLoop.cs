// ============================================================
//  L04 · foreach loop
//  Topics: foreach (type var in collection),
//          read-only loop variable (can't assign),
//          use with arrays, strings (chars), List<T>
// ============================================================
namespace LoopsPractice.Lessons;

public static class L04_ForeachLoop
{
    public static void Run()
    {
        Console.WriteLine("--- L04 · foreach loop ---");

        // TODO: declare string[] cities and print each one.
        // string[] cities = ["Madrid", "Barcelona", "Valencia"];
        // foreach (string city in cities) { Console.WriteLine(city); }

        // TODO: iterate over a string character by character.
        //       Count how many vowels are in "programming".
        string word = "programming";
        int vowels = 0;
        // foreach (char c in word)
        //     if ("aeiouAEIOU".Contains(c)) vowels++;
        Console.WriteLine($"Vowels in '{word}': {vowels}");

        // TODO: use foreach to sum all elements in an int[].
        int[] numbers = [3, 7, 2, 9, 1, 4];
        int total = 0;
        // foreach (int n in numbers) total += n;
        Console.WriteLine($"Total: {total}");

        // READ-ONLY trap:
        // foreach (int n in numbers) n *= 2;  // ← CS1656: won't compile
        // TODO: use a for loop to double every element instead.

        Console.WriteLine();
    }
}
