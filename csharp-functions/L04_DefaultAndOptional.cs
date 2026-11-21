// ============================================================
//  L04 · Default / optional parameters
//  Topics: parameter = defaultValue in the signature,
//          optional params must come AFTER required ones,
//          named arguments (arg: value) for clarity
// ============================================================
namespace FunctionsPractice.Lessons;

public static class L04_DefaultAndOptional
{
    public static void Run()
    {
        Console.WriteLine("--- L04 · Default & optional parameters ---");

        // TODO: call Repeat("hi")         → prints "hi" once (default times=1)
        //       call Repeat("hi", 3)      → prints "hi" three times
        //       call Repeat("hi", times: 2) → same with named arg
        Repeat("hi");
        Repeat("hi", 3);
        Repeat("hi", times: 2);

        // TODO: call BuildTag("hello")          → <p>hello</p>
        //       call BuildTag("hello", "h1")    → <h1>hello</h1>
        //       call BuildTag("hi", tag: "span") → <span>hi</span>
        Console.WriteLine(BuildTag("hello"));
        Console.WriteLine(BuildTag("hello", "h1"));
        Console.WriteLine(BuildTag("hi", tag: "span"));

        // Rule: optional parameters must be AFTER required ones.
        // static void Bad(int x = 0, int y) { }  // ← compile error
        // static void OK (int y, int x = 0) { }  // ← correct order

        Console.WriteLine();
    }

    static void Repeat(string text, int times = 1)
    {
        // TODO: for loop printing 'text' each iteration
    }

    static string BuildTag(string content, string tag = "p")
    {
        // TODO: return $"<{tag}>{content}</{tag}>";
        return "";
    }
}
