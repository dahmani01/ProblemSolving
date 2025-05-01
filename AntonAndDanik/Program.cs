string input = Console.ReadLine();
int n = int.Parse(input);
input = Console.ReadLine();
int i=0 , anton = 0 , danik=0 ; 
while (i < input.Length && ((anton < n/2 +1) && (danik < n/2+1) )){
    if (input[i] == 'A')
    {
        anton++;
    }
    else
    {
        danik++;
    }

    i++;
}

if (anton > danik)
{
    Console.WriteLine("Anton");
}
else if (danik > anton)
{
    Console.WriteLine("Danik");
}
else
{
    Console.WriteLine("Friendship");
}