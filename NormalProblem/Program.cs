int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string a = Console.ReadLine();
    char[] b = new char[a.Length];
    for (int j = 0; j < a.Length; j++)
    {
        if (a[j] == 'p') b[a.Length - j - 1] = 'q';
        else if (a[j] == 'q') b[a.Length - j - 1] = 'p';
        else b[a.Length - j - 1] = 'w';
    }
    Console.WriteLine(new string(b));
}