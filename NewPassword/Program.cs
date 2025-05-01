string[] input = Console.ReadLine().Split(" ");
short n = short.Parse(input[0]), k = short.Parse(input[1]);
short i =0 ;
HashSet<char> set = new HashSet<char>();
while (i < k)
{
    char randomChar = (char)('a' + new Random().Next(0, 26));
    if (!set.Contains(randomChar))
    {
        set.Add(randomChar);
        i++;
    }
 
}
char[] password = new char[n];
short index = 0;
for (i = 0; i < n; i++)
{
    if (index == k)
    {
        index = 0;
    }
    password[i] = set.ElementAt(index);
    index++;
}
Console.WriteLine(string.Join("", password));