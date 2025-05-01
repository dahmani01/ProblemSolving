int n = int.Parse(Console.ReadLine());
int[] numberOfBirds = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int m = int.Parse(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    string[] shotDetails = Console.ReadLine().Split(" ");
    int x = int.Parse(shotDetails[0]) - 1; 
    int y = int.Parse(shotDetails[1]);

    int nbOnLeft = y - 1; 
    int nbOnRight = numberOfBirds[x] - y; 
    
    if (x > 0) 
    {
        numberOfBirds[x - 1] += nbOnLeft;
    }
    if (x < n - 1) 
    {
        numberOfBirds[x + 1] += nbOnRight;
    }
    numberOfBirds[x] -= (nbOnLeft + 1 + nbOnRight); 
}

for (int i = 0; i < numberOfBirds.Length; i++)
{
    Console.WriteLine(numberOfBirds[i]);
}