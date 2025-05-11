string a = Console.ReadLine();
string b = Console.ReadLine();

if(a.Equals(b))
    Console.WriteLine(-1);
else if (a.Length < b.Length)
    Console.WriteLine(b.Length);
else 
    Console.WriteLine(a.Length);