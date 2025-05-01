var username = Console.ReadLine();
var set = new HashSet<string>();
for (int i = 0; i < username.Length; i++)
{
    set.Add(username[i].ToString());
}

if (set.Count % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}