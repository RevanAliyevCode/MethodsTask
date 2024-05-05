// See https://aka.ms/new-console-template for more information


Console.WriteLine(Methods.FindMultiple(3, 4));
Console.WriteLine(Methods.FindPow(3));
Console.WriteLine(Methods.FindSumArr([1, 4, 5, 6]));
Console.WriteLine(Methods.Greeting(name: "Revan", surname: "Eliyev"));
Console.WriteLine(Methods.ReverseString("malaS"));
Methods.IsDivided(9);
Methods.IsDivided(21);
Console.WriteLine(Methods.FindPerimeter(1, 2, 3));
Console.WriteLine(Methods.FindPerimeter(3));
Console.WriteLine(Methods.FindSpaces(" a  f c c b"));

public static class Methods
{
    public static int FindMultiple(int a, int b)
    {
        return a * b;
    }

    public static int FindPow(int a)
    {
        return a * a;
    }

    public static int FindSumArr(int[] arr)
    {
        return arr.Sum();
    }

    public static string Greeting(string name, string surname)
    {
        return $"Xos gelmisen {name} {surname}";
    }

    public static string ReverseString(string word)
    {
        string reversedArr = "";
        for (int i = word.Length - 1; i >= 0; i--)
            reversedArr += word[i];
        return reversedArr;
    }

    public static void IsDivided(int num)
    {
        if (num % 7 == 0) Console.WriteLine("7 ye bolunur");
        else Console.WriteLine((num - (num % 7)));
    }

    public static int FindPerimeter(int a, int b, int c)
    {
        return a + b + c;
    }

    public static int FindPerimeter(int a)
    {
        return a * 4;
    }

    public static int FindSpaces(string word)
    {
        int spaces = 0;

        foreach (char c in word)
        {
            if (c == ' ') spaces++;
        }

        return spaces;
    }
}

