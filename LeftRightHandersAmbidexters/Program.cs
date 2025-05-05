string[] input = Console.ReadLine().Split(" ");
short l = short.Parse(input[0]), r = short.Parse(input[1]) , a = short.Parse(input[2]);
Console.WriteLine(getTeamSize(l,r,a));

int getTeamSize(short l, short r, short a){
    int diff = Math.Abs(l - r);

    if (a > diff)
    {
        int teamsize = Math.Max(l, r) * 2;
        int remaining = a - diff;
        teamsize += getEven((short)remaining);
        return teamsize;
    }
    else
    {
        int teamsize = (Math.Min(l, r) +a) *2;
        return teamsize;
    }
}

short getEven(short a)
{
    if (a % 2 == 0 && a>0) return a;
    a--;
    return (short)(a>0 ? a : 0);
}