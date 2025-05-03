string input = Console.ReadLine().ToLower();
char[] vowels = ['a', 'o', 'y', 'e', 'u', 'i'];

List<string> word = new List<string>();
foreach (var letter in input)
{
    if (!vowels.Contains(letter))
        word.Add($".{letter}");
}

Console.WriteLine(string.Join("", word));
