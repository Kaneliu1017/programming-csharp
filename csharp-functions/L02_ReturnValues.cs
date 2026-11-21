// ============================================================
//  L02 · Return values
//  Topics: return type in signature, return statement,
//          storing the result in a variable,
//          every code path must return a value
// ============================================================
namespace FunctionsPractice.Lessons;

public static class L02_ReturnValues
{
    public static void Run()
    {
        Console.WriteLine("--- L02 · Return values ---");

        // TODO: call Square(4) and print the result. Expected: 16.
        Console.WriteLine($"Square(4) = {Square(4)}");

        // TODO: call Celsius(100) → should return 212.0 (Fahrenheit).
        Console.WriteLine($"100°C = {Celsius(100)}°F");

        // TODO: call IsEven(7) → false.  IsEven(8) → true.
        Console.WriteLine($"7 even? {IsEven(7)}");
        Console.WriteLine($"8 even? {IsEven(8)}");

        // TODO: call Max(3, 9) → 9.
        Console.WriteLine($"Max(3,9) = {Max(3, 9)}");

        // TODO: call Initials("Ana Garcia") → "A.G."
        Console.WriteLine($"Initials: {Initials("Ana Garcia")}");

        Console.WriteLine();
    }

    static int Square(int n)
    {
        // TODO: return n * n;
        return 0;
    }

    static double Celsius(double c)
    {
        // TODO: return c * 9.0 / 5.0 + 32;
        return 0;
    }

    static bool IsEven(int n)
    {
        // TODO: return n % 2 == 0;
        return false;
    }

    static int Max(int a, int b)
    {
        // TODO: if (a > b) return a; return b;
        return 0;
    }

    static string Initials(string fullName)
    {
        // TODO: split on space, take first char of each word + '.'
        //       "Ana Garcia" → "A.G."
        return "";
    }
}
