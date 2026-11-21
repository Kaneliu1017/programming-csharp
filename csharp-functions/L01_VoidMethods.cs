// ============================================================
//  L01 · void methods
//  Topics: static void MethodName(), calling a method,
//          methods that do work but return nothing,
//          splitting code into reusable pieces
// ============================================================
namespace FunctionsPractice.Lessons;

public static class L01_VoidMethods
{
    public static void Run()
    {
        Console.WriteLine("--- L01 · void methods ---");

        // TODO: call PrintGreeting() — it should print "Hello, World!"
        PrintGreeting();

        // TODO: call PrintLine() — it should print a line of 20 dashes.
        PrintLine();

        // TODO: call PrintBox("Hi") — it should print the text
        //       surrounded by a box made of * characters:
        //       ******
        //       * Hi *
        //       ******
        PrintBox("Hi");

        // TODO: call PrintNumbersUpTo(5) — prints 1 2 3 4 5
        PrintNumbersUpTo(5);

        Console.WriteLine();
    }

    // TODO: implement each method below

    static void PrintGreeting()
    {
        // TODO
    }

    static void PrintLine()
    {
        // TODO: Console.WriteLine(new string('-', 20));
    }

    static void PrintBox(string text)
    {
        // TODO: build the border with new string('*', text.Length + 4)
    }

    static void PrintNumbersUpTo(int n)
    {
        // TODO: for loop, print each number on the same line
    }
}
