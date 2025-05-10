int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
int firstCity = int.Parse(input[0]);
int lastCity = int.Parse(input[n-1]) ;
Console.WriteLine($"{Math.Abs(int.Parse(input[1]) - firstCity )} {Math.Abs(lastCity - firstCity)}");
for (int i = 1; i < n-1; i++)
{
    int previousCity = int.Parse(input[i-1]); 
    int currentCity = int.Parse(input[i]);
    int nextCity = int.Parse(input[i+1]);
    int minDistance = Math.Min(Math.Abs(currentCity - previousCity), Math.Abs(nextCity - currentCity));
    int maxDistance = Math.Max(Math.Abs(currentCity - firstCity), Math.Abs(lastCity- currentCity));
    Console.WriteLine($"{minDistance} {maxDistance}");
}
Console.WriteLine($"{Math.Abs(lastCity - int.Parse(input[n-2]) )} {Math.Abs(lastCity - firstCity)}");