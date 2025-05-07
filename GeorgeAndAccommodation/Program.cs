short n = short.Parse(Console.ReadLine());
short numberOfRooms = 0;
for (short i = 1; i <= n; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    short p = short.Parse(input[0]), q = short.Parse(input[1]);
    if (q-p >= 2) numberOfRooms++;
}
Console.WriteLine(numberOfRooms);