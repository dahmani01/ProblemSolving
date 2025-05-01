int n = int.Parse(Console.ReadLine());
var teams = new List<string>() ; 
for (int i = 0; i < n; i++)
{
    teams.Add(Console.ReadLine());
}

int count =0 ;

for (int i = 0; i < teams.Count; i++)
{
    var teamColors = teams[i].Split(" ").Select(int.Parse).ToArray();
    for (int j = i + 1; j < teams.Count; j++)
    {
        var oppositeteamColors = teams[j].Split(" ").Select(int.Parse).ToArray();
        if (teamColors[0] == oppositeteamColors[1])
        {
            count++;
        }

        if (teamColors[1] == oppositeteamColors[0])
        {
            count++;
        }
    }
}

Console.WriteLine(count);