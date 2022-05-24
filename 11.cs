Console.Write("Enter the range of massive: ");
int number = int.Parse(Console.ReadLine());
List<int> list = new List<int>(Enumerable.Range(1, number));

foreach (var num in list)
{
    Console.Write(num + " ");
}
Console.WriteLine();
Shuffle(list);


static void Shuffle(List<int> list)
{
    Random random = new Random();
    var twinList = list.OrderBy(x => random.Next()).ToList();

    while (!IsShuffled(list, twinList))
    {
        twinList = list.OrderBy(x => random.Next()).ToList();
    }

    foreach (var num in twinList)
    {
        Console.Write(num + " ");
    }
}
static bool IsShuffled(List<int> list, List<int> twinList)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] == twinList[i])
            return false;
    }
    return true;
}
