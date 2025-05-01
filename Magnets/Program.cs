var n = int.Parse(Console.ReadLine());
var postions = new int[n];
for (int i = 0; i < n; i++)
{
    postions[i] = int.Parse(Console.ReadLine());
}

var numberOfGroupes = 1;
for (int i = 1; i < postions.Length; i++)
{
    if (postions[i-1] != postions[i])
    {
        numberOfGroupes++;
    }
    
}
Console.WriteLine(numberOfGroupes);