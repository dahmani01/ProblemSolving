int n = int.Parse(Console.ReadLine());
int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] output = new int[n];
for (int i = 0; i < n; i++)
{
    output[input[i] - 1] = i + 1;
}

Console.WriteLine(string.Join(" ", output));