Console.Write("Enter the year: ");
int year = int.Parse(Console.ReadLine());
List<DateOnly> dates = new List<DateOnly>();
for (int month = 1; month <= 12; month++)
{
    DateOnly date = LastDayOfMonth(year, month);
    dates.Add(GetLastThursday(date));
}

foreach (var date in dates)
{
    Console.WriteLine(date);
}

static DateOnly GetLastThursday(DateOnly date)
{
    DateOnly twinDate = date;
    for (int i = 0; i <= 7; i++)
    {
        if (twinDate.DayOfWeek == DayOfWeek.Thursday)
        {
            return twinDate;
        }
        else
        {
            twinDate = twinDate.AddDays(-1);
        }
    }
    return twinDate;
}

static DateOnly LastDayOfMonth(int year, int month)
{
    DateOnly date = new DateOnly();
    for (int day = 31; day > 0; day--)
    {
        try
        {
            date = new DateOnly(year, month, day);
            break;
        }
        catch { }
    }
    return date;
}
