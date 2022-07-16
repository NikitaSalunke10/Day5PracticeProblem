int noOftimes = 5;
int heads=0, tails=0;
double hPercentage, tPercentage;
Random random = new Random();
for(int i = 0; i < noOftimes; i++)
{
    int coinFlip = random.Next(0, 2);
    if (coinFlip < 0.5)
    {
        Console.WriteLine("Its Tails");
        tails++;
    }
    else
    {
        Console.WriteLine("Its Heads");
        heads++;
    }
}
hPercentage = 100 * heads / noOftimes;
tPercentage = 100 * tails / noOftimes;
Console.WriteLine("Heads % : " +hPercentage+ " vs Tails % : " +tPercentage);