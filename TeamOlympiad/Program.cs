short n = Convert.ToInt16(Console.ReadLine());
short[] t = Console.ReadLine().Split(' ').Select(short.Parse).ToArray();
 
List<short> programmers = new List<short>();
List<short> mathematicians = new List<short>();
List<short> sportsmen = new List<short>();
 
for (short i = 0; i < n; i++)
{
    switch (t[i])
    {
        case 1:
            programmers.Add((short)(i + 1));
            break;
        case 2:
            mathematicians.Add((short)(i + 1));
            break;
        case 3:
            sportsmen.Add((short)(i + 1));
            break;
    }
}
 
int numberOfTeams = Math.Min(programmers.Count, Math.Min(mathematicians.Count, sportsmen.Count));
 
Console.WriteLine(numberOfTeams);
 
for (int i = 0; i < numberOfTeams; i++)
{
    Console.WriteLine($"{programmers[i]} {mathematicians[i]} {sportsmen[i]}");
}