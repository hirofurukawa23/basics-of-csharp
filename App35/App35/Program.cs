int index = 0;
while (index <= 10)
{
    index++;
    if (index % 2 == 1)
    {
        continue;
    }
    Console.WriteLine(index.ToString());
}