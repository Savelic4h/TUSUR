using System.Globalization;

static void CalculateDate(int day, int month, int year)
{
    try
    {
        DateOnly julianCalendar = new DateOnly(year, month, day, new JulianCalendar());
        Console.WriteLine(julianCalendar);
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Date isn't corrent!");
        return;
    }
}
CalculateDate(15, 2, 2020);
