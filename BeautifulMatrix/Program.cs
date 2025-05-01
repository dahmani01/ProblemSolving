int minimum = 0;
for (int i = 0; i < 5; i++)
{
    string line = Console.ReadLine();
    string[] tokens = line.Split(" ");
    for (int j = 0; j < 5; j++)
    {
        int n = int.Parse(tokens[j]);
        if (n == 1)
        {
            minimum = Math.Abs(2 - i) + Math.Abs(2 - j); 
        }
    }
}
Console.WriteLine(minimum);