// ============================================================
//  L05 · Method overloading
//  Topics: same name, different parameter types or count,
//          compiler picks the right one at compile time,
//          overloading ≠ overriding (different concept)
// ============================================================
namespace FunctionsPractice.Lessons;

public static class L05_Overloading
{
    public static void Run()
    {
        Console.WriteLine("--- L05 · Method overloading ---");

        // The compiler picks the right Add based on argument types.
        Console.WriteLine(Add(3, 4));           // int version → 7
        Console.WriteLine(Add(1.5, 2.3));       // double version → 3.8
        Console.WriteLine(Add("Hello", " World")); // string version → "Hello World"

        // TODO: call Describe(42)        → "Number: 42"
        //       call Describe("hello")   → "Text: hello"
        //       call Describe(3.14)      → "Decimal: 3.14"
        Console.WriteLine(Describe(42));
        Console.WriteLine(Describe("hello"));
        Console.WriteLine(Describe(3.14));

        // TODO: call Print(5)      → prints 5
        //       call Print(5, 3)   → prints 5 three times
        //       call Print("hi")   → prints "hi"
        Print(5);
        Print(5, 3);
        Print("hi");

        Console.WriteLine();
    }

    // Overloaded Add — same name, different parameter types
    static int    Add(int a, int b)       => a + b;
    static double Add(double a, double b) => a + b;
    static string Add(string a, string b) => a + b;

    // TODO: add three overloads of Describe — int, string, double
    static string Describe(int n)    { return ""; }  // TODO
    static string Describe(string s) { return ""; }  // TODO
    static string Describe(double d) { return ""; }  // TODO

    // TODO: add two overloads of Print
    static void Print(int n)         { }  // TODO: Console.WriteLine(n)
    static void Print(int n, int times) { }  // TODO: loop
    static void Print(string s)      { }  // TODO: Console.WriteLine(s)
}
