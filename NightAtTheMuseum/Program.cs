string word = Console.ReadLine();
int pointer = 'a';
int steps = 0; 
for (int i = 0; i < word.Length; i++)
{
    int diff = Math.Abs(word[i] - pointer);
    if (diff <= 13)
    {
        steps += diff;
    }
    else
    {
        steps += (26 - diff);
    }
    pointer = word[i];
}
Console.WriteLine(steps);