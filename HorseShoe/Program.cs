int[] colors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
HashSet<int> colorSet = new HashSet<int>(colors);
int colorsCount = 4 - colorSet.Count;
Console.WriteLine(colorsCount);