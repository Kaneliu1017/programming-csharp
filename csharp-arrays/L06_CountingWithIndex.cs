// ============================================================
//  L06 · Counting with an index array
//  Topics: int[] freq of size max+1,
//          freq[value]++ pattern,
//          char counting: freq[c - 'a']++
// ============================================================
namespace ArrayPractice.Lessons;

public static class L06_CountingWithIndex
{
    public static void Run()
    {
        Console.WriteLine("--- L06 · Counting with an index array ---");

        int[] grades = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5];

    static void Run()
        //       e.g.  1 appears 2 times
        int[] freq = FrequencyTable(grades);
        for (int v = 0; v < freq.Length; v++)
            if (freq[v] > 0)
                Console.WriteLine($"  {v} appears {freq[v]} time(s)");

        // TODO: count character frequencies in a string
        string word = "banana";
        int[] charFreq = CharFrequency(word);
        // print only letters present
        for (int i = 0; i < 26; i++)
            if (charFreq[i] > 0)
                Console.WriteLine($"  '{(char)('a' + i)}' = {charFreq[i]}");

        Console.WriteLine();
    }

    static int[] FrequencyTable(int[] data)
    {
        // TODO: find max, create array of size max+1, fill with counts
        return [];
    }

    static int[] CharFrequency(string s)
    {
        // TODO: int[] freq = new int[26];
        //       foreach (char c in s) freq[c - 'a']++;
        return new int[26];
    }
}
