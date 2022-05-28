int index = 1;
while (index <= 10)
{
    Console.WriteLine(index.ToString());
    if (index == 7)
    {
        Console.WriteLine("ループを終了します。");
        break;
    }
    index++;
}