string input = Console.ReadLine();
string[] values = input.Split(' ');
int n = int.Parse(values[0]);
int h = Convert.ToInt32(values[1]);
input = Console.ReadLine();
values = input.Split(' ');
int[] PersonHeights = new int[n];
for (int i = 0 ; i < values.Length; i++)
{ 
    PersonHeights[i] = int.Parse(values[i]);
}

int width = 0;
for (int i = 0; i < n; i++)
{
    if (PersonHeights[i] > h)
    {
        width += 2; 
    }
    else
    {
        width += 1; 
    }
}
Console.WriteLine(width);