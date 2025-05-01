string a = Console.ReadLine().ToLower();
string b = Console.ReadLine().ToLower();
int i = 0;
while ( i < a.Length)
{
    if (a[i] > b[i])
    {
        Console.WriteLine("1");
        break;
    } 
    else if (a[i] < b[i])
    {
        Console.WriteLine("-1");
        break;
    }
    i++;
}
if (i == a.Length)
    Console.WriteLine("0");