int inputNumber;
while (true)
{
    Console.WriteLine("数値を入力してください。");

    string input = Console.ReadLine();
    if (!int.TryParse(input, out inputNumber))
    {
        Console.WriteLine("数値ではありません。");
        Console.WriteLine("");
        continue;
    }
    break;
}

for (int tate = 0; tate < inputNumber; tate++)
{
    for (int yoko = 0; yoko <= tate; yoko++)
    {
        //表示は縦と同じところまで -> 3行目なら3列
        Console.Write("■");
    }
    Console.WriteLine();
}