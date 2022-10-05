var testCases = new (string testCase, bool expectedResult)[]
{
    ("()", true),
    ("()[]{}", true),
    ("(]", false),
    ( "([)]", false ),
    ( "([])", true )
};

bool IsValid(string s)
{
    var result = new Dictionary<char, int>
    {
        { '{', 0 },
        { '(', 0 },
        { '[', 0 }
    };

    var endToken = new Dictionary<char, char>
    {
        {  '}', '{' },
        { ')', '('},
        { ']', '[' }
    };

    var lastOpens = new Stack<char> { };
    foreach (char c in s)
    {
        if (result.TryGetValue(c, out _))
        {
            result[c] = result[c] + 1;
            lastOpens.Push(c);
        } else if (endToken.TryGetValue(c, out var c1))
        {
            if (lastOpens.Count == 0)
            {
                return false;
            }
            var lastOpen = lastOpens.Pop();
            if (lastOpen != c1)
            {
                return false;
            }
            result[c1] = result[c1] - 1;
            if (result[c1] < 0)
            {
                return false;
            }
        }
    }

    foreach(var r in result)
    {
        if (r.Value != 0)
            return false;
    }
    return true;
}

int passedResults = 0;
foreach(var testCase in testCases)
{
    var actualResult = IsValid(testCase.testCase);
    Console.WriteLine($"{testCase.testCase} expected result {testCase.expectedResult}, actual {actualResult}");
    passedResults += (actualResult == testCase.expectedResult) ? 1 : 0;
}

Console.WriteLine($"Test result {passedResults} / {testCases.Length}");
