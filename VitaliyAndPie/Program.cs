int n = int.Parse(Console.ReadLine()); 
string input = Console.ReadLine();

Dictionary<char, short> keys = new Dictionary<char, short>();
int keysToBuy = 0;

for (int i = 1; i <= input.Length; i++) 
{
    char currentLetter = input[i - 1];
    if (i % 2 != 0)
    {
        if (keys.ContainsKey(currentLetter))
        {
            keys[currentLetter]++;
        }
        else
        {
            keys[currentLetter] = 1;
        }
    }
    else
    {
        char neededKey = char.ToLower(currentLetter);
        if (!keys.ContainsKey(neededKey) || keys[neededKey] == 0)
        {
            keysToBuy++;
        }
        else
        {
            keys[neededKey]--;
        }
    }
}

Console.WriteLine(keysToBuy);