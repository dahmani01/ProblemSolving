int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string a = Console.ReadLine();
    char[] b = new char[a.Length];
    for (int j = 0; j < a.Length; j++)
    {
        if (a[j] == 'p') b[j] = 'q';
        else if (a[j] == 'q') b[j] = 'p';
        else b[j] = 'w';
    }
    Console.WriteLine(new string(b));
}