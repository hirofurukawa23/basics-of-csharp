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
    for (int yoko = 0; yoko <= inputNumber; yoko++)
    {
        //表示は縦と同じところまで -> 3行目なら3列
        Console.Write("■");

        //横と縦が一致したら、
        //横のループから抜けて次の行へ進む
        if (yoko == tate)
        {
            break;
        }
    }
    Console.WriteLine();
}