string[] input = Console.ReadLine().Split(" ");
int n = int.Parse(input[0]);
double x = double.Parse(input[1]);
double numberOfIcereamsLeft = x;
int distressedChildren = 0; 
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine().Split(" ");
    string operation = input[0];
    double d = double.Parse(input[1]);
    if (operation == "+")
    {
        numberOfIcereamsLeft += d;
    }
    else
    {
        if (numberOfIcereamsLeft - d < 0)
        {
            distressedChildren++;
        }
        else
        {
            numberOfIcereamsLeft -= d;
        }
    }
}
Console.WriteLine($"{numberOfIcereamsLeft} {distressedChildren}");