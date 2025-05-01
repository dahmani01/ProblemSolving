string s = Console.ReadLine();
string t =  Console.ReadLine();

int position = 1; 
for (int i = 0;i < t.Length; i++)
{
    if (t[i] == s[position-1] )
    {
        position++;
    }
}
Console.WriteLine(position);