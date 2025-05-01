int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
string blackSquareSplits = Console.ReadLine();
int calories = 0;
for (int i = 0; i < blackSquareSplits.Length; i++)
{
    int split = (int) Char.GetNumericValue(blackSquareSplits[i]);
    calories += a[split-1];
}
Console.WriteLine(calories);