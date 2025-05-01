int n = int.Parse(Console.ReadLine());  
string colors = Console.ReadLine();
int i =0 , nbrOfStonesToRemove = 0;

while (i < colors.Length - 1 )
{
    if (colors[i] == colors[i + 1])
    {
        nbrOfStonesToRemove++;
    }
    i++; 
}
Console.WriteLine(nbrOfStonesToRemove);