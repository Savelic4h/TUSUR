Console.WriteLine("Введите сумму покупки!");
double boughtSum = double.Parse(Console.ReadLine());
if (boughtSum > 1000)
    Console.WriteLine(boughtSum * 0.9);
else
    Console.WriteLine(boughtSum);
