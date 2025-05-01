string s = Console.ReadLine();
string t = Console.ReadLine();
if (s.Length != t.Length)
{
    Console.WriteLine("NO");
    return; 
}

for (short i = 0; i < s.Length; i++)
{
    if (s[i] != t[s.Length - i -1])
    {
        Console.WriteLine("NO");
        return;
    }
}

Console.WriteLine("YES");
