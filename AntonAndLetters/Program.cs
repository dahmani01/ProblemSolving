string input = Console.ReadLine();
if (input.Length - 2 < 1)
{
    Console.WriteLine("0");
    return;
}
string[] letters = input.Substring(1, input.Length - 2).Split(", " );
HashSet<string> lettersSet = new HashSet<string>();
 
 
for (int i = 0; i < letters.Length; i++)
{
    lettersSet.Add(letters[i]);
}
 
Console.WriteLine(lettersSet.Count);