int n = int.Parse(Console.ReadLine());
int[] events = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int availablePolice = 0 , untreatedCrimes = 0 ;
for (int i = 0; i < n; i++)
{
    if (events[i] != -1)
    {
        availablePolice+=events[i];
    }
    else
    {
        if (availablePolice > 0)
        {
            availablePolice--;
        }
        else
        {
            untreatedCrimes++;
        }
    }
}
Console.WriteLine(untreatedCrimes);