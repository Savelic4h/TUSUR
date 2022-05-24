string strNumber = Console.ReadLine();
int power = 0;
for (int i = strNumber.Length - 1; i >= 0; i--)
{
    if (i == 0)
        Console.WriteLine($"{strNumber[power]}*10^{i}");
    else
        Console.Write($"{strNumber[power]}*10^{i}+");
    power++;
}
