// ============================================================
//  L02 · Ranges, copies and arrays in methods
//  Topics: ^1 (index from end), a..b (range), for vs foreach,
//          reference semantics (b = a aliases),
//          copy with [..a], == compares references,
//          method can change elements (x[i]=) but not the
//          variable itself (x= has no effect on caller)
// ============================================================
namespace ArrayPractice.Lessons;

public static class L02_RangesCopiesMethods
{
    public static void Run()
    {
        Console.WriteLine("--- L02 · Ranges, copies and methods ---");

        int[] data = [10, 20, 30, 40, 50];

        // TODO: print the last element using the ^ operator
        Console.WriteLine(data[^1]);
    static void Run()
        // TODO: print a slice using a range, e.g. data[1..4]
        int[] slice = data[1..4];
        Console.WriteLine(string.Join(",", slice));

        // TODO: show that b = data is an alias (same reference)
        //       modify b[0] and show data[0] also changed.
        int[] b = data;
        b[0] = 999;
        Console.WriteLine($"b[0] = {b[0]}, data[0] = {data[0]}");

        // TODO: show that c = [..data] is a real copy
        //       modify c[0] and show data[0] is unchanged.
        int[] c = [..data];
        c[0] = 777;
        Console.WriteLine($"c[0] = {c[0]}, data[0] = {data[0]}");

        // TODO: write a helper method AddTen(int[] arr) below
        //       that adds 10 to every element (changes the caller's array).
        AddTen(data);
        Console.WriteLine("After AddTen: " + string.Join(", ", data));

        Console.WriteLine();
    }

    static void AddTen(int[] arr)
    {
        // TODO: loop and add 10 to each element
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] += 10;
        }
    }
}
