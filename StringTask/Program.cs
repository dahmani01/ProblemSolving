using System.Text;

string input = Console.ReadLine().ToLower();
HashSet<char> vowels = new HashSet<char> { 'a', 'o', 'y', 'e', 'u', 'i' };
StringBuilder sb = new StringBuilder();

foreach (var letter in input)
{
    if (!vowels.Contains(letter))
    {
        sb.Append('.').Append(letter);
    }
}

Console.WriteLine(sb.ToString());