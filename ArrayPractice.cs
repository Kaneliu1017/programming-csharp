// ============================================================
//  C# Arrays — Practice
// ============================================================

// ── run with:  dotnet-script ArrayPractice.cs
//              OR add to a .csproj and use  dotnet run

Console.WriteLine("=== U8 Arrays — Practice ===\n");

L01_WhatAnArrayIs();
L02_RangesCopiesMethods();
L03_ClassicAlgorithms();
L04_JaggedArrays();
L05_ReadingByColumns();
L06_CountingWithIndex();
L07_ParallelArraysAndTuples();
L08_ExamPatterns();

Console.WriteLine("\n=== Done ===");


// ============================================================
//  L01 · What an array is
//  Topics: new T[n] defaults, collection expressions [a,b],
//          spread [..v, x], foreach, string.Join
// ============================================================
static void L01_WhatAnArrayIs()
{
    Console.WriteLine("--- L01 · What an array is ---");

    // TODO: declare an int array of length 5 using new int[5]
    //       and print its default values with a foreach loop.
    int[] defaults = new int[5];
    foreach (int value in defaults)
    {
        Console.WriteLine(value);
    }

    // TODO: declare an int array using a collection expression
    //       [1, 2, 3, 4, 5] and print it with string.Join.
    int[] nums = [1, 2, 3, 4, 5];
    Console.WriteLine(string.Join(",", nums));

    // TODO: use a spread expression to combine two arrays into one.
    int[] a = [1, 2];  int[] b = [3, 4];
    int[] combined = [..a, ..b];

    // TODO: print combined with string.Join(", ", combined)

    Console.WriteLine(string.Join(",", combined));
}


// ============================================================
//  L02 · Ranges, copies and arrays in methods
//  Topics: ^1 (index from end), a..b (range), for vs foreach,
//          reference semantics (b = a aliases),
//          copy with [..a], == compares references,
//          method can change elements (x[i]=) but not the
//          variable itself (x= has no effect on caller)
// ============================================================
static void L02_RangesCopiesMethods()
{
    Console.WriteLine("--- L02 · Ranges, copies and methods ---");

    int[] data = [10, 20, 30, 40, 50];

    // TODO: print the last element using the ^ operator
    Console.WriteLine(data[^1]);

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


// ============================================================
//  L03 · Classic array algorithms
//  Topics: sum & average (cast to double), max with position,
//          count matching a condition, linear search (return -1),
//          append (% Length), rotate left / right
// ============================================================
static void L03_ClassicAlgorithms()
{
    Console.WriteLine("--- L03 · Classic algorithms ---");

    int[] nums = [4, 9, 2, 7, 1, 8, 3];

    // TODO: compute and print sum and average
    //       average needs a (double) cast: (double)sum / nums.Length
    int sum = Sum(nums);
    double avg = Average(nums);
    Console.WriteLine($"Sum {sum}  Avg {avg:F2}");

    // TODO: find max value and its position
    (int max, int pos) = MaxWithPosition(nums);
    Console.WriteLine($"Max {max} at index {pos}");

    // TODO: count how many elements are greater than 5
    int count = CountGreaterThan(nums, 5);
    Console.WriteLine($"Count > 5: {count}");

    // TODO: search for 7; search for 99 (should return -1)
    Console.WriteLine($"Index of  7: {LinearSearch(nums, 7)}");
    Console.WriteLine($"Index of 99: {LinearSearch(nums, 99)}");

    Console.WriteLine();
}

static int Sum(int[] arr)
{
    // TODO
    return 0;
}

static double Average(int[] arr)
{
    // TODO  (cast: (double)Sum(arr) / arr.Length)
    return 0;
}

static (int value, int index) MaxWithPosition(int[] arr)
{
    // TODO
    return (0, 0);
}

static int CountGreaterThan(int[] arr, int threshold)
{
    // TODO
    return 0;
}

static int LinearSearch(int[] arr, int target)
{
    // TODO: return index if found, -1 if not found
    return -1;
}


// ============================================================
//  L04 · Jagged arrays
//  Topics: int[][], null rows, a[i].Length,
//          a[r][c] access, transpose, column totals, diagonal
// ============================================================
static void L04_JaggedArrays()
{
    Console.WriteLine("--- L04 · Jagged arrays ---");

    // A jagged array where rows have different lengths
    int[][] table = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ];

    // TODO: print every element using nested for loops (a[r][c])

    // TODO: compute and print the total of all elements
    Console.WriteLine($"Total: {JaggedTotal(table)}");

    // TODO: compute column sums (assume rectangular table here)
    int[] colSums = ColumnSums(table);
    Console.WriteLine("Col sums: " + string.Join(", ", colSums));

    // TODO: compute the main diagonal sum (top-left → bottom-right)
    Console.WriteLine($"Diagonal sum: {DiagonalSum(table)}");

    Console.WriteLine();
}

static int JaggedTotal(int[][] t)
{
    // TODO
    return 0;
}

static int[] ColumnSums(int[][] t)
{
    // TODO: for each column j, sum t[i][j] over all rows i
    return [];
}

static int DiagonalSum(int[][] t)
{
    // TODO: sum t[i][i]
    return 0;
}


// ============================================================
//  L05 · Reading a table by columns
//  Topics: iterating columns first (outer loop = col),
//          building column sub-arrays, using a[i].Length safely
// ============================================================
static void L05_ReadingByColumns()
{
    Console.WriteLine("--- L05 · Reading by columns ---");

    int[][] table = [
        [1, 4, 7],
        [2, 5, 8],
        [3, 6, 9]
    ];

    // TODO: print each column as a comma-separated line
    //       e.g.  Col 0: 1, 2, 3
    //             Col 1: 4, 5, 6
    //             Col 2: 7, 8, 9

    // TODO: find which column has the highest sum

    Console.WriteLine();
}


// ============================================================
//  L06 · Counting with an index array
//  Topics: int[] freq of size max+1,
//          freq[value]++ pattern,
//          char counting: freq[c - 'a']++
// ============================================================
static void L06_CountingWithIndex()
{
    Console.WriteLine("--- L06 · Counting with an index array ---");

    int[] grades = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5];

    // TODO: build a frequency array and print each value with its count
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


// ============================================================
//  L07 · Parallel arrays and tuples
//  Topics: (string Name, int Units)[] tuple arrays,
//          deconstruction (var (name, units) = arr[i]),
//          jagged arrays of tuples,
//          sorting and searching with tuples
// ============================================================
static void L07_ParallelArraysAndTuples()
{
    Console.WriteLine("--- L07 · Parallel arrays and tuples ---");

    // Parallel arrays (old style)
    string[] names   = ["Alice", "Bob", "Carol"];
    int[]    scores  = [88, 72, 95];

    // TODO: print each name with its score using a for loop

    // Tuple array (modern style)
    (string Name, int Score)[] students = [
        ("Alice", 88),
        ("Bob",   72),
        ("Carol", 95)
    ];

    // TODO: print each student using deconstruction:
    //       foreach (var (name, score) in students)

    // TODO: find the student with the highest score

    // TODO: (optional) jagged array of tuples — e.g. a list of
    //       subjects per student: (string Subject, int Grade)[][]

    Console.WriteLine();
}


// ============================================================
//  L08 · Exam review — patterns and errors
//  Topics: nullable elements string?[],
//          IndexOutOfRangeException, NullReferenceException,
//          CS1656 (foreach loop variable is read-only),
//          Array.Sort, Array.IndexOf
// ============================================================
static void L08_ExamPatterns()
{
    Console.WriteLine("--- L08 · Exam patterns and errors ---");

    // ── Nullable array elements ──
    string?[] words = ["hello", null, "world", null, "!"];

    // TODO: print only non-null elements (use  if (w != null) )

    // ── Array.Sort and Array.IndexOf ──
    int[] nums = [5, 3, 8, 1, 9, 2];
    Array.Sort(nums);
    Console.WriteLine("Sorted: " + string.Join(", ", nums));
    Console.WriteLine("Index of 8: " + Array.IndexOf(nums, 8));

    // ── Safe bounds check ──
    // TODO: write SafeGet(int[] arr, int i) below that returns
    //       the element or prints "out of range" without crashing.
    Console.WriteLine(SafeGet(nums, 2));
    Console.WriteLine(SafeGet(nums, 99));

    // ── CS1656: foreach variable is read-only ──
    // The code below does NOT compile — it is here as a reminder.
    // Uncomment to see the error, then fix it with a for loop.
    //
    // foreach (int n in nums)
    //     n += 1;   // ← CS1656: cannot assign to 'n'

    // TODO: rewrite the increment using a for loop instead

    Console.WriteLine();
}

static string SafeGet(int[] arr, int i)
{
    // TODO: use try/catch IndexOutOfRangeException
    //       return the element as a string on success,
    //       "out of range" on failure.
    return "";
}
