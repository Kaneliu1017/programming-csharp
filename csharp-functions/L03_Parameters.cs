// ============================================================
//  L03 · Parameters and arguments
//  Topics: value types are COPIED (int, double, bool, char),
//          reference types share the object (arrays, strings),
//          parameter name vs argument name can differ
// ============================================================
namespace FunctionsPractice.Lessons;

public static class L03_Parameters
{
    public static void Run()
    {
        Console.WriteLine("--- L03 · Parameters ---");

        // Value type — the method gets a COPY; original unchanged.
        int x = 10;
        TryDoubleValue(x);
        Console.WriteLine($"x after TryDoubleValue: {x}");  // still 10

        // Array — the method gets the SAME array object; elements can change.
        int[] arr = [1, 2, 3, 4, 5];
        DoubleElements(arr);
        Console.WriteLine("arr after DoubleElements: " + string.Join(", ", arr));  // doubled

        // TODO: call Greet("Alice", 3) → prints "Hello, Alice!" three times.
        Greet("Alice", 3);

        // TODO: call Clamp(15, 0, 10) → should return 10 (clamped to max).
        //       Clamp(-5, 0, 10) → 0.  Clamp(7, 0, 10) → 7.
        Console.WriteLine($"Clamp(15,0,10) = {Clamp(15, 0, 10)}");
        Console.WriteLine($"Clamp(-5,0,10) = {Clamp(-5, 0, 10)}");
        Console.WriteLine($"Clamp(7,0,10)  = {Clamp(7, 0, 10)}");

        Console.WriteLine();
    }

    static void TryDoubleValue(int n)
    {
        n *= 2;   // only the local copy changes
        Console.WriteLine($"Inside TryDoubleValue: {n}");
    }

    static void DoubleElements(int[] arr)
    {
        // TODO: for loop, arr[i] *= 2;
    }

    static void Greet(string name, int times)
    {
        // TODO: for loop printing "Hello, {name}!" each iteration
    }

    static int Clamp(int value, int min, int max)
    {
        // TODO: if value < min return min; if > max return max; return value
        return 0;
    }
}
