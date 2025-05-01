int n = int.Parse(Console.ReadLine());
int[] cardNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int sereja = 0, dima = 0;
int i = 0, j = n - 1;

bool isSerejaTurn = true;

while (i <= j)
{
    int selectedCard = (cardNumbers[i] > cardNumbers[j]) ? cardNumbers[i++] : cardNumbers[j--];

    if (isSerejaTurn)
        sereja += selectedCard;
    else
        dima += selectedCard;

    isSerejaTurn = !isSerejaTurn;
}

Console.WriteLine($"{sereja} {dima}");