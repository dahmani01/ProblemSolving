int n = int.Parse(Console.ReadLine());
var snackSizes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

bool[] seen = new bool[n + 1];
int nextExpected = n;

for (int i = 0; i < n; i++) {
    int s = snackSizes[i];
    seen[s] = true;
    
    while (nextExpected >= 1 && seen[nextExpected]) {
        Console.Write(nextExpected + " ");
        nextExpected--;
    }
    Console.WriteLine();
}