string input = Console.ReadLine();
string[] tokens = input.Split(' ');
int a = int.Parse(tokens[0]) , b= int.Parse(tokens[1]);
int i =0 ;
while (a <= b)
{
    a *= 3;
    b *= 2;
    i++;
}
Console.WriteLine(i);