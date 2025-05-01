int n = int.Parse(Console.ReadLine());
int[] cols = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Array.Sort(cols);

Console.WriteLine(string.Join(" ", cols));