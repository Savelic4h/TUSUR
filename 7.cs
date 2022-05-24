static void CalculateDate(int day, int month, int year)
{
    try
    {
        DateOnly dateIn = new DateOnly(year, month, day);

        Console.WriteLine("Date is correct!");
        Console.WriteLine($"Gone {dateIn.DayOfYear}");
        Console.WriteLine($"Left {366 - dateIn.DayOfYear}");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Date isn't corrent!");
        return;
    }
}
CalculateDate(15, 6, 2020);
