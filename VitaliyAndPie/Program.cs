short n = short.Parse(Console.ReadLine());
string input = Console.ReadLine();

Dictionary<char, short> keys = new Dictionary<char, short>();

int keysToBuy = 0;

for (short i = 1; i <= input.Length; i++)
{
    if (i % 2 != 0)
    {
        ManageDictionaries(keys, input[i - 1]);
    }
    else
    {
        int keysForThisDoor;
        try
        {
            keysForThisDoor = keys[(char)(input[i - 1] + 32)];
        }
        catch (KeyNotFoundException)
        {
            keysForThisDoor = 0;
        }

        if (keysForThisDoor == 0)
        {
            keysToBuy++;
        }
        else
        {
            keys[(char)(input[i - 1] + 32)]--;
        }
    }
}


Console.WriteLine(keysToBuy);

void ManageDictionaries(Dictionary<char, short> dictionary, char c)
{
    if (dictionary.ContainsKey(c))
    {
        dictionary[c]++;
    }
    else
    {
        dictionary.Add(c, 1);
    }
}