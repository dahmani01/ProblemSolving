int[] money = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int k = money[0], r = money[1];
// x * k % 10 =0 ou = r
int x = 1;
while ((x * k) % 10 != 0 && (x * k) % 10 != r)
{
    x++;
}
Console.WriteLine(x);