int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = input[0], t = input[1], k = input[2], d = input[3];
        
int nbrOfCycles = (int)Math.Ceiling((double)n / k);
int timeWithOneOven = nbrOfCycles * t;
        
if (n <= k)
{
    Console.WriteLine("NO");
    return;
}
int nbrOfCyclesBeforeD = (int)Math.Floor((double)d / t);
int cakesBakedBeforeD = nbrOfCyclesBeforeD * k;
        
int remainingCakes = n - cakesBakedBeforeD;
        
if (remainingCakes <= 0)
{
    Console.WriteLine("NO");
    return;
}
        
int remainingCycles = (int)Math.Ceiling((double)remainingCakes / (2 * k));
int totalTimeWithTwoOvens = d + remainingCycles * t;

if (totalTimeWithTwoOvens < timeWithOneOven)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}