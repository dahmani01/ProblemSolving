int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    string[] split = line.Split(' ');
    int totale = 0; 
    for (int j = 0; j < 3; j++)
    {
        totale += int.Parse(split[j]);
    }

    if (totale >= 2)
    {
        sum += 1;
    }
}
Console.WriteLine(sum);