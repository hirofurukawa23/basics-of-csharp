string input = Console.ReadLine();
int number;
if (int.TryParse(input, out number))
{
    if (number == 5 || number == 8)
    {
        Console.WriteLine("5または8でした。");
    }
}
Console.WriteLine("終了します。");