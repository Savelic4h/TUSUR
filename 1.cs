List<int> numbers = new List<int>();
var test = true;
while (test)
{
    int i = int.Parse(Console.ReadLine());
    if (i != 0)
        numbers.Add(i);
    else
        test = false;
}
Console.WriteLine("Введите x!");
int check = int.Parse(Console.ReadLine());
var count = 0;
for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] > check)
        count += numbers[i];
}
Console.WriteLine($"{count} - сумма");
